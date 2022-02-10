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
        private readonly IMapper mapper;

        public CarService(IRepository<Car> autopartRepository, IMapper mapper)
        {
            this.carRepository = autopartRepository;
            this.mapper = mapper;
        }

        public async Task Create(CreateCarDto car)
        {
            if (car == null)
            {
                return;
            }

            var carEntity = new Car
            {
                Name = car.Name,
                CarModelId = car.ModelId,
                CategoryId = car.CategoryId,
                DateAdded = DateTime.UtcNow,
                ModifiedDate = DateTime.UtcNow,
                Price = car.Price
            };

            await carRepository.AddAsync(carEntity);

            await carRepository.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var entity = carRepository.All().Where(x => x.Id == id).FirstOrDefault();

            if (entity is null)
            {
                throw new InvalidOperationException();
            }

            carRepository.Delete(entity);

            await carRepository.SaveChangesAsync();
        }

        public async Task Edit(UpdateCar input)
        {
            var entity = carRepository.AllAsNoTracking().Where(x => x.Id == input.Id).FirstOrDefault();

            if (entity is null)
            {
                throw new InvalidOperationException();
            }

            entity = mapper.Map<Car>(input);
            carRepository.Update(entity);
            await carRepository.SaveChangesAsync();
        }

        public IEnumerable<CarDto> GetAll()
        {
            var result = carRepository.All().Include(x => x.CarModel).ThenInclude(x => x.CarMake);
            return carRepository.All().Include(x => x.CarModel).ThenInclude(x => x.CarMake).Select(x => mapper.Map<Car, CarDto>(x)).AsEnumerable();
        }
    }
}
