namespace VangelAuto.Services
{
    using AutoMapper;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using VangelAuto.Data.Models;
    using VangelAuto.Data.Repositories;
    using VangelAuto.Services.Dto;

    public class CarService : ICarService
    {
        private readonly IRepository<Car> carRepository;
        private readonly IRepository<CarModel> carModelRepository;
        private readonly IMapper mapper;

        public CarService(IRepository<Car> autopartRepository, IRepository<CarModel> carModelRepository, IMapper mapper)
        {
            this.carRepository = autopartRepository;
            this.carModelRepository = carModelRepository;
            this.mapper = mapper;
        }

        public void Create(CreateCarDto car)
        {
            if (car == null)
            {
                return;
            }

            var carEntity = new Car
            {
                Name = car.Name,
                CarModelId = car.ModelId,
                CarModel = new CarModel() { Id = car.ModelId },
                CategoryId = car.CategoryId,
                DateAdded = DateTime.UtcNow,
                ModifiedDate = DateTime.UtcNow,
                Price = car.Price
            };

            carRepository.Add(carEntity);
        }

        public void Delete(int id)
        {
            var entity = carRepository.All().Where(x => x.Id == id).FirstOrDefault();

            if (entity is null)
            {
                throw new InvalidOperationException();
            }

            carRepository.Delete(entity);
        }

        public void Edit(UpdateCar input)
        {
            var entity = carRepository.All().Where(x => x.Id == input.Id).FirstOrDefault();

            if (entity is null)
            {
                throw new InvalidOperationException();
            }

            entity = mapper.Map<Car>(input);
            carRepository.Update(entity);
        }

        public IEnumerable<CarDto> GetAll()
        {
            return carRepository.All().Select(c =>
            {
                var carModel = carModelRepository.All().Where(cm => cm.Id == c.CarModel.Id).FirstOrDefault();

                if (carModel is not null)
                {
                    c.CarModel.MakeName = carModel.MakeName;
                    c.CarModel.ModelName = carModel.ModelName;
                }
                
                return mapper.Map<Car, CarDto>(c);
            }).AsEnumerable();
        }
    }
}
