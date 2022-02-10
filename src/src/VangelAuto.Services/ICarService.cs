namespace VangelAuto.Services
{
    using System.Collections.Generic;
    using VangelAuto.Services.Dto;
    using System.Threading.Tasks;

    public interface ICarService
    {
        Task Create(CreateCarDto autopart);

        IEnumerable<CarDto> GetAll();

        Task Delete(int id);

        Task Edit(UpdateCar input);
    }
}
