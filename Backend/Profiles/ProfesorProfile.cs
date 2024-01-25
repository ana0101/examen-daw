using AutoMapper;
using ExamenDAW.Entities;
using ExamenDAW.Models;

namespace ExamenDAW.Profiles
{
    public class ProfesorProfile : Profile
    {
        public ProfesorProfile() 
        { 
            CreateMap<ProfesorDto, Profesor>().ReverseMap();
        }
    }
}
