using Microsoft.AspNetCore.Mvc;

namespace BullsRideToTampa.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult About()
        {
            ViewData["Title"] = "About Us";
            return View();
        }
    }
}
