namespace VangelAuto.Services
{
    using System.Collections.Generic;
    using VangelAuto.Services.Dto;

    public interface ICarMakesService
    {
        IEnumerable<MakeModelDto> GetAll();
    }
}
