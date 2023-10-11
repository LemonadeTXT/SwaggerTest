using AutoMapper;
using SwaggerTest.Common.DTOs;
using SwaggerTest.Models.Models;

namespace SwaggerTest.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<UserDto, User>().ReverseMap();
        }
    }
}