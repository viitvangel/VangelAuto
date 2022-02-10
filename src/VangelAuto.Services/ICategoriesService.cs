namespace VangelAuto.Services
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using VangelAuto.Services.Dto;

    public interface ICategoriesService
    {
        IEnumerable<CategoryDto> GetAll();

        Task Create(CategoryDto input);
    }
}
