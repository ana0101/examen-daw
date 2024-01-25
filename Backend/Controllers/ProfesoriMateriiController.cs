using AutoMapper;
using ExamenDAW.Entities;
using ExamenDAW.Models;
using ExamenDAW.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExamenDAW.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfesoriMateriiController : ControllerBase
    {
        private readonly IProfesoriMateriiRepository _profesoriMateriiRepository;
        private readonly IMapper _mapper;

        public ProfesoriMateriiController(IProfesoriMateriiRepository profesoriMateriiRepository, IMapper mapper)
        {
            _profesoriMateriiRepository = profesoriMateriiRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetProfesoriMateriiAsync()
        {
            var profesoriMaterii = await _profesoriMateriiRepository.GetProfesoriMateriiAsync();
            return Ok(profesoriMaterii);
        }

        [HttpPost]
        public async Task<IActionResult> PostProfesorMaterie(ProfesorMaterie profesorMaterie)
        {
            await _profesoriMateriiRepository.PostProfesorMaterieAsync(profesorMaterie);
            return Ok(profesorMaterie);
        }
    }
}
