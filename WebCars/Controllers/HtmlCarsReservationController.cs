using Cars.Entities;
using Infrastructure.DataAccess;
using Microsoft.AspNetCore.Mvc;

namespace WebBook.Controllers
{
    [Route("html/[controller]")]
    public class HtmlCarsReservationController : Controller
    {
        private ICarsReservationRepository _carsReservationRepository { get; set; }

        public HtmlCarsReservationController(ICarsReservationRepository carsReservationRepository)
        {
            _carsReservationRepository = carsReservationRepository;
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View(_carsReservationRepository.GetAll());
        }


        [HttpGet("{id}")]
        public ActionResult Details(int id)
        {
            return View(_carsReservationRepository.Get(id));
        }

        [HttpGet("create")]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost("create")]
        [ValidateAntiForgeryToken]
        public ActionResult Create([FromForm] CarsReservation carsReservation)
        {
            try
            {
                _carsReservationRepository.Add(carsReservation);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        [HttpGet("update/{id}")]
        public ActionResult Edit(int id)
        {
            return View(_carsReservationRepository.Get(id));
        }

        [HttpPost("update/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, [FromForm] CarsReservation carsReservation)
        {
            try
            {
                _carsReservationRepository.Update(carsReservation);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}