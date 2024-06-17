using Microsoft.AspNetCore.Mvc;

namespace BullsRideToTampa.Controllers
{
    public class BusinessController : Controller
    {
        public IActionResult Business()
        {
            ViewData["Title"] = "Timings and Price";
            return View();
        }
    }
}


