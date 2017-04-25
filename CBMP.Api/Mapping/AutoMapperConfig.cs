using AutoMapper;
using CBMP.Api.Dtos;
using CBMP.Api.Models;

namespace CBMP.Api.Mapping
{
    public class AutoMapperConfig
    {
        public static void Initialize()
        {
            Mapper.Initialize((config) =>
            {
                config.CreateMap<Osoba, OsobaDto>().ReverseMap();
            });
        }
    }
}