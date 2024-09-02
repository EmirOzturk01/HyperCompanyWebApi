using AutoMapper;
using Hyper.BL.Managers.Abstract;
using Hyper.BL.Managers.Concrete;
using Hyper.Entities.Models.Concrete;
using Hyper.WebApi.Models.Dtos.Boat;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hyper.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoatController : ControllerBase
    {
        private readonly IBoatManager _boatManager;
        private readonly IMapper _mapper;

        public BoatController(IBoatManager boatManager, IMapper mapper)
        {
            _boatManager = boatManager;
            _mapper = mapper;
        }

        // api/Boat?color={color}
        [Authorize(Roles = "Admin,Visitor")]
        [HttpGet]
        public async Task<IActionResult> BoatList(string? color)
        {
            if (!string.IsNullOrEmpty(color))
            {
                // Renge göre filtreleme yap
                var boatsByColor = await _boatManager.GetByColorAsync(color);
                if (boatsByColor.Count() < 1)
                {
                    return NotFound($"Araç rengi '{color}' bulunamadı.");
                }
                return Ok(boatsByColor);
            }

            var boats = await _boatManager.GetAllAsync();
            return Ok(boats);
        }

        [Authorize(Roles = "Admin,Visitor")]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBoatById(int id)
        {
            var boat = await _boatManager.GetByIdAsync(id);
            if (boat == null)
            {
                return NotFound($"Araç ID {id} bulunamadı.");
            }
            return Ok(boat);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> AddBoat([FromForm] BoatCreateDTO boatCreateDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var boat = _mapper.Map<Boat>(boatCreateDTO);
            await _boatManager.InsertAsync(boat);
            return Ok("Araç başarıyla eklendi");
        }

        [Authorize(Roles = "Admin")]
        [HttpDelete]
        public async Task<IActionResult> DeleteBoat(int id)
        {
            var boat = await _boatManager.GetByIdAsync(id);
            if (boat == null)
            {
                return NotFound($"Araç ID {id} bulunamadı.");
            }
            _boatManager.DeleteAsync(boat);
            return Ok("Araç başarıyla silindi.");
        }

        [Authorize(Roles = "Admin")]
        [HttpPut]
        public async Task<IActionResult> UpdateBoat([FromForm] BoatUpdateDTO boatUpdateDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var existingBoat = await _boatManager.GetByIdAsync(boatUpdateDTO.Id);
            if (existingBoat == null)
            {
                return NotFound($"Araç ID {boatUpdateDTO.Id} bulunamadı.");
            }

            var boat = _mapper.Map(boatUpdateDTO, existingBoat);
            await _boatManager.UpdateAsync(boat);
            return Ok("Araç başarıyla güncellendi.");
        }
    }
}
