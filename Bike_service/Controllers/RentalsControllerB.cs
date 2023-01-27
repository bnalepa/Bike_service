using Microsoft.AspNetCore.Mvc;
using Bike_service.Models;
using Microsoft.EntityFrameworkCore;
using Bike_service.Data;
using Bike_service.Repository;

namespace Bike_service.ControllersB
{

    public class RentalsControllerB : Controller
    {
        private static IRental _rental;

        public RentalsControllerB(IRental rental)
        {
            _rental = rental;
        }

        public async Task<IActionResult> Index()
        {
            return  View(await _rental.GetAllRental());
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
