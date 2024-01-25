using AutoMapper;
using ExamenDAW.Entities;
using ExamenDAW.Models;

namespace ExamenDAW.Profiles
{
    public class MaterieProfile : Profile
    {
        public MaterieProfile()
        {
            CreateMap<MaterieDto, Materie>().ReverseMap();
        }
    }
}
