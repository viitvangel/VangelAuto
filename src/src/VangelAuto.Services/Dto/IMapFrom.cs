using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VangelAuto.Services
{
    using AutoMapper;

    public interface IMapFrom<T>
    {
        void Mapping(Profile mapper) => mapper.CreateMap(typeof(T), this.GetType());
    }
}
