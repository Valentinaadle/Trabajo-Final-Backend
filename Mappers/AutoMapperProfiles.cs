using AutoMapper;
using TrabajoFinal.Dtos;
using TrabajoFinal.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TrabajoFinal.Mappers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Clase, ClaseDto>().ReverseMap();
            CreateMap<Socio, SocioDto>().ReverseMap();
        }
    }

}
