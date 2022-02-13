namespace VangelAuto.Services
{
    using System.Collections.Generic;
    using VangelAuto.Services.Dto;

    public interface ICarModelService
    {
        IEnumerable<CarModelDto> GetAll();

        void Create(CarModelDto categoryDto);
    }
}
