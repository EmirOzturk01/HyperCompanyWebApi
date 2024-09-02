using AutoMapper;
using Hyper.BL.Managers.Abstract;
using Hyper.Entities.Models.Concrete;
using Hyper.WebApi.Models.Dtos.Car;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hyper.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarManager _carManager;
        private readonly IMapper _mapper;

        public CarController(ICarManager carManager, IMapper mapper)
        {
            _carManager = carManager;
            _mapper = mapper;
        }

        // api/Car?color={color}
        [Authorize(Roles = "Admin,Visitor")]
        [HttpGet]
        public async Task<IActionResult> CarList(string? color)
        {
            if (!string.IsNullOrEmpty(color))
            {
                // Renge göre filtreleme yap
                var carsByColor = await _carManager.GetByColorAsync(color);
                if (carsByColor.Count() < 1)
                {
                    return NotFound($"Araç rengi '{color}' bulunamadı.");
                }
                return Ok(carsByColor);
            }

            var cars = await _carManager.GetAllAsync();
            return Ok(cars);
        }

        // api/Car/color?color={color}

        /*[HttpGet("color")]
        public async Task<IActionResult> GetCarsByColor(string color)
        {
            var cars = await _carManager.GetByColorAsync(color);
            return Ok(cars);
        }*/

        [Authorize(Roles = "Admin,Visitor")]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCarById(int id)
        {
            var car = await _carManager.GetByIdAsync(id);
            if (car == null)
            {
                return NotFound($"Araç ID {id} bulunamadı.");
            }
            return Ok(car);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost("{id}/headlights")]
        public async Task<IActionResult> ToggleHeadlights(int id,[FromForm] bool headlightsOn)
        {
            var car = await _carManager.GetByIdAsync(id);
            if (car == null)
            {
                return NotFound($"Araç ID {id} bulunamadı.");
            }

            car.HeadlightsOn = headlightsOn;
            await _carManager.UpdateAsync(car);

            return Ok();
        }


        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> AddCar([FromForm] CarCreateDTO carCreateDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var car = _mapper.Map<Car>(carCreateDTO);
            await _carManager.InsertAsync(car);
            return Ok("Araç başarıyla eklendi.");
        }

        [Authorize(Roles = "Admin")]
        [HttpDelete]
        public async Task<IActionResult> DeleteCar(int id)
        {
            var car = await _carManager.GetByIdAsync(id);
            if (car == null) 
            {
                return NotFound($"Araç ID {id} bulunamadı.");
            }
            _carManager.DeleteAsync(car);
            return Ok("Araç başarıyla silindi.");
        }


        [Authorize(Roles = "Admin")]
        [HttpPut]
        public async Task<IActionResult> UpdateCar([FromForm] CarUpdateDTO carUpdateDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var existingCar = await _carManager.GetByIdAsync(carUpdateDTO.Id);
            if (existingCar == null)
            {
                return NotFound($"Araç ID {carUpdateDTO.Id} bulunamadı.");
            }

            var car = _mapper.Map(carUpdateDTO, existingCar);
            await _carManager.UpdateAsync(car);
            return Ok("Araç başarıyla güncellendi.");
        }
    }
}
