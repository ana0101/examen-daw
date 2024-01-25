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
    public class MateriiController : ControllerBase
    {
        private readonly IMateriiRepository _materiiRepository;
        private readonly IMapper _mapper;

        public MateriiController(IMateriiRepository materiiRepository, IMapper mapper)
        {
            _materiiRepository = materiiRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetMaterii()
        {
            var materii = await _materiiRepository.GetMateriiAsync();
            return Ok(materii);
        }

        [HttpPost]
        public async Task<IActionResult> PostMaterie(MaterieDto materieDto)
        {
            var materie = _mapper.Map<Materie>(materieDto);
            await _materiiRepository.PostMaterieAsync(materie);
            return Ok(materie);
        }
    }
}
