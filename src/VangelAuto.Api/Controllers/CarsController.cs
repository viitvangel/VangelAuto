using AutoMapper;
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
    public class CarsController : ControllerBase
    {
        private readonly ICarService carService;
        private readonly IMapper mapper;

        public CarsController(ICarService carService, IMapper mapper)
        {
            this.carService = carService;
            this.mapper = mapper;
        }

        [HttpGet]
        public ActionResult GetAll()
        {
            return Ok(carService.GetAll());
        }

        [HttpPost]
        public ActionResult Create(CreateCarDto input)
        {
            carService.Create(input);

            return Ok();
        }

        [HttpDelete]
        public ActionResult Delete(int id)
        {
           carService.Delete(id);

            return Ok();
        }

        [HttpPut]
        public ActionResult Edit(UpdateCar input)
        {
            carService.Edit(input);

            return Ok();
        }
    }
}
