using Microsoft.AspNetCore.Mvc;
using Bike_service.Models;
using Microsoft.EntityFrameworkCore;
using Bike_service.Data;

namespace Bike_service.Controllers
{

    public class RentalsController : Controller
    {
        private static AppDBContext _context = context;
        public IActionResult Index()
        {
            return View(_context.Rentals.ToList());
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
