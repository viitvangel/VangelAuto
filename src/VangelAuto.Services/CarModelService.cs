namespace VangelAuto.Services
{
    using AutoMapper;
    using System.Collections.Generic;
    using System.Linq;
    using VangelAuto.Data.Models;
    using VangelAuto.Data.Repositories;
    using VangelAuto.Services.Dto;

    public class CarModelService : ICarModelService
    {
        private readonly IRepository<CarModel> carModelRepository;
        private readonly IMapper mapper;

        public CarModelService(IRepository<CarModel> carMakeRepository, IMapper mapper)
        {
            this.carModelRepository = carMakeRepository;
            this.mapper = mapper;
        }

        public IEnumerable<CarModelDto> GetAll()
        {
            return carModelRepository.All().Select(x => mapper.Map<CarModel, CarModelDto>(x));
        }

        public void Create(CarModelDto categoryDto)
        {
            carModelRepository.Add(mapper.Map<CarModel>(categoryDto));
        }
    }
}
