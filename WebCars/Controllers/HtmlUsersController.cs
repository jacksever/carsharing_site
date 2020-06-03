using Cars.Entities;
using Infrastructure.DataAccess;
using Microsoft.AspNetCore.Mvc;

namespace WebBook.Controllers
{
    [Route("html/[controller]")]
    public class HtmlUsersController : Controller
    {
        private IUserRepository _usersRepository { get; set; }

        public HtmlUsersController(IUserRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View(_usersRepository.GetAll());
        }


        [HttpGet("{id}")]
        public ActionResult Details(int id)
        {
            return View(_usersRepository.Get(id));
        }

        [HttpGet("create")]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost("create")]
        [ValidateAntiForgeryToken]
        public ActionResult Create([FromForm] User user)
        {
            try
            {
                _usersRepository.Add(user);

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
            return View(_usersRepository.Get(id));
        }

        [HttpPost("update/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, [FromForm] User user)
        {
            try
            {
                _usersRepository.Update(user);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}