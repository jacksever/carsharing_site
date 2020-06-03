using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cars.Entities;
using Infrastructure.DataAccess;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebCars.Controllers
{
    [Route("cars-list")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private ICarsRepository _carsRepository { get; set; }

        public CarsController(ICarsRepository carsRepository)
        {
            _carsRepository = carsRepository;
        }

        [HttpGet]
        public IEnumerable<Car> Get()
        {
            return _carsRepository.GetAll();
        }


        [HttpGet("{id}")]
        public Car Get(int id)
        {
            return _carsRepository.Get(id);
        }


        [HttpPost]
        public ActionResult Post([FromBody] Car car)
        {
            _carsRepository.Add(car);
            return Ok();
        }


        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Car car)
        {
            _carsRepository.Update(car);
            return Ok();
        }

    }
}
