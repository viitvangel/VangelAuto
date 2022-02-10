using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VangelAuto.Services;

namespace VangelAuto.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarMakesController : ControllerBase
    {
        private readonly ICarMakesService carMakesService;

        public CarMakesController(ICarMakesService carMakesService)
        {
            this.carMakesService = carMakesService;
        }

        [HttpGet]
        public ActionResult GetAll()
        {
            return Ok(carMakesService.GetAll());
        }
    }
}
