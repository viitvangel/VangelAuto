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
    public class CarModelsController : ControllerBase
    {
        private readonly ICarModelService carModelsService;

        public CarModelsController(ICarModelService carMakesService)
        {
            this.carModelsService = carMakesService;
        }

        [HttpGet]
        public ActionResult GetAll()
        {
            return Ok(carModelsService.GetAll());
        }

        [HttpPost]
        public ActionResult Create(CarModelDto input)
        {
            carModelsService.Create(input);

            return Ok();
        }
    }
}
