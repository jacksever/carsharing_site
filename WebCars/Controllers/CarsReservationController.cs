using System.Collections.Generic;
using Cars.Entities;
using Infrastructure.DataAccess;
using Microsoft.AspNetCore.Mvc;

namespace WebCars.Controllers
{
    [Route("cars-reservation-list")]
    [ApiController]
    public class CarsReservationController : ControllerBase
    {
        private ICarsReservationRepository _carsReservationRepository { get; set; }

        public CarsReservationController(ICarsReservationRepository carsReservationRepository)
        {
            _carsReservationRepository = carsReservationRepository;
        }

        [HttpGet]
        public IEnumerable<CarsReservation> Get()
        {
            return _carsReservationRepository.GetAll();
        }
    }
}
