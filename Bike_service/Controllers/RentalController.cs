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


    }
}
