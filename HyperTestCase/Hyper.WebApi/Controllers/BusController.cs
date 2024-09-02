using AutoMapper;
using Hyper.BL.Managers.Abstract;
using Hyper.BL.Managers.Concrete;
using Hyper.Entities.Models.Concrete;
using Hyper.WebApi.Models.Dtos.Bus;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hyper.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusController : ControllerBase
    {
        private readonly IBusManager _busManager;
        private readonly IMapper _mapper;

        public BusController(IBusManager busManager, IMapper mapper)
        {
            _busManager = busManager;
            _mapper = mapper;
        }

        // api/Bus?color={color}
        [Authorize(Roles = "Admin,Visitor")]
        [HttpGet]
        public async Task<IActionResult> BusList(string? color)
        {
            if (!string.IsNullOrEmpty(color))
            {
                // Renge göre filtreleme yap
                var busesByColor = await _busManager.GetByColorAsync(color);
                if (busesByColor.Count() < 1)
                {
                    return NotFound($"Araç rengi '{color}' bulunamadı.");
                }
                return Ok(busesByColor);
            }

            var buses = await _busManager.GetAllAsync();
            return Ok(buses);
        }

        [Authorize(Roles = "Admin,Visitor")]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBusById(int id)
        {
            var bus = await _busManager.GetByIdAsync(id);
            if (bus == null)
            {
                return NotFound($"Araç ID {id} bulunamadı.");
            }
            return Ok(bus);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> AddBus([FromForm] BusCreateDTO busCreateDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var bus = _mapper.Map<Bus>(busCreateDTO);
            await _busManager.InsertAsync(bus);
            return Ok($"Araç başarıyla eklendi.");
        }

        [Authorize(Roles = "Admin")]
        [HttpDelete]
        public async Task<IActionResult> DeleteBus(int id)
        {
            var bus = await _busManager.GetByIdAsync(id);
            if (bus == null)
            {
                return NotFound($"Araç ID {id} bulunamadı.");
            }
            _busManager.DeleteAsync(bus);
            return Ok($"Araç başarıyla silindi.");
        }

        [Authorize(Roles = "Admin")]
        [HttpPut]
        public async Task<IActionResult> UpdateBus([FromForm] BusUpdateDTO busUpdateDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var existingBus = await _busManager.GetByIdAsync(busUpdateDTO.Id);
            if (existingBus == null)
            {
                return NotFound($"Araç ID {busUpdateDTO.Id} bulunamadı.");
            }

            var bus = _mapper.Map(busUpdateDTO, existingBus);
            await _busManager.UpdateAsync(bus);
            return Ok($"Araç başarıyla güncellendi.");
        }

    }
}
