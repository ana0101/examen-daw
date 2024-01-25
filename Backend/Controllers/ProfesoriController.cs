using AutoMapper;
using ExamenDAW.Entities;
using ExamenDAW.Models;
using ExamenDAW.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ExamenDAW.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfesoriController : ControllerBase
    {
        private readonly IProfesoriRepository _profesoriRepository;
        private readonly IMapper _mapper;

        public ProfesoriController(IProfesoriRepository profesoriRepository, IMapper mapper)
        {
            _profesoriRepository = profesoriRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetProfesori()
        {
            var profesori = await _profesoriRepository.GetProfesoriAsync();
            return Ok(profesori);
        }

        [HttpGet("cu-materii")]
        public async Task<IActionResult> GetProfesoriCuMaterii()
        {
            var profesori = await _profesoriRepository.GetProfesoriCuMateriiAsync();
            return Ok(profesori);
        }

        [HttpPost]
        public async Task<IActionResult> PostProfesor(ProfesorDto profesorDto)
        {
            var profesor = _mapper.Map<Profesor>(profesorDto);
            await _profesoriRepository.PostProfesorAsync(profesor);
            return Ok(profesor);
        }
    }
}
