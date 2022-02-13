namespace VangelAuto.Services
{
    using System.Collections.Generic;
    using VangelAuto.Services.Dto;
    using System.Threading.Tasks;

    public interface ICarService
    {
        void Create(CreateCarDto autopart);

        IEnumerable<CarDto> GetAll();

        void Delete(int id);

        void Edit(UpdateCar input);
    }
}
