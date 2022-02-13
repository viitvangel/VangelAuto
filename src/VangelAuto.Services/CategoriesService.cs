namespace VangelAuto.Services
{
    using AutoMapper;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using VangelAuto.Data.Models;
    using VangelAuto.Data.Repositories;
    using VangelAuto.Services.Dto;

    public class CategoriesService : ICategoriesService
    {
        private readonly IRepository<Category> categoryRepository;
        private readonly IMapper mapper;

        public CategoriesService(IRepository<Category> categoryRepository, IMapper mapper)
        {
            this.categoryRepository = categoryRepository;
            this.mapper = mapper;
        }

        public IEnumerable<CategoryDto> GetAll()
        {
            return categoryRepository.All().Select(x => new CategoryDto
            {
                Id = x.Id,
                Name = x.Name
            }).AsEnumerable(); ;
        }

        public void Create(CategoryDto categoryDto)
        {
            categoryRepository.Add(mapper.Map<Category>(categoryDto));
        }
    }
}
