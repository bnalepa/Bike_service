using Microsoft.AspNetCore.Mvc;

namespace Bike_service.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
