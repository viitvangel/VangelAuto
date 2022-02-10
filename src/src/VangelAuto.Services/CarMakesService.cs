namespace VangelAuto.Services
{
    using System.Collections.Generic;
    using System.Linq;
    using VangelAuto.Data.Models;
    using VangelAuto.Data.Repositories;
    using VangelAuto.Services.Dto;

    public class CarMakesService : ICarMakesService
    {
        private readonly IRepository<CarMake> carMakesRepository;

        public CarMakesService(IRepository<CarMake> carMakeRepository)
        {
            this.carMakesRepository = carMakeRepository;
        }

        public IEnumerable<MakeModelDto> GetAll()
        {
            return carMakesRepository.All().Select(x => new MakeModelDto
            {
                Id = x.Id,
                Name = x.Name,
                Models = x.CarModels.Select(x => new ModelDto
                {
                    Id = x.Id,
                    Name = x.Name,
                })
            });
        }
    }
}
