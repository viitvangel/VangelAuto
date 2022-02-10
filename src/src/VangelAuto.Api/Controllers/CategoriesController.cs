using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VangelAuto.Services;
using VangelAuto.Services.Dto;

namespace VangelAuto.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoriesService categoriesService;

        public CategoriesController(ICategoriesService categoriesService)
        {
            this.categoriesService = categoriesService;
        }

        [HttpGet]
        public ActionResult GetAll()
        {
            return Ok(this.categoriesService.GetAll());
        }

        [HttpPost]
        public async Task<ActionResult> Create(CategoryDto input)
        {
            await categoriesService.Create(input);

            return Ok();
        }
    }
}
