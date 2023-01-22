using Microsoft.AspNetCore.Mvc;
using Bike_service.Models;

namespace Bike_service.Controllers
{

    public class RentalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CreateReservation()
        {
            return View("CreateReservation");
        }
        [HttpPost]
        public IActionResult AfterCreateReservation()
        {
            return View("AfterCreateReservation");
        }

    }
}
