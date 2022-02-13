using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using VangelAuto.Data.Models;
using VangelAuto.Services;
using VangelAuto.Services.Dto;

namespace VangelAuto.Api.Config
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CarDto, Car>().ReverseMap()
                .ForMember(x => x.Model, opt => opt.MapFrom(y => y.CarModel.ModelName))
                .ForMember(x => x.Make, opt => opt.MapFrom(y => y.CarModel.MakeName));
            CreateMap<CreateCarDto, Car>().ReverseMap();
            CreateMap<Car, UpdateCar>().ReverseMap().ForMember(x => x.CarModelId, opt => opt.MapFrom(y => y.ModelId));
            CreateMap<CategoryDto, Category>().ReverseMap();
            CreateMap<CarModel, CarModelDto>().ReverseMap();
        }
    }
}
