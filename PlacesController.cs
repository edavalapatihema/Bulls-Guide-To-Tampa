using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using BullsRideToTampa.Models;
using Newtonsoft.Json.Linq;

namespace BullsRideToTampa.Controllers
{
    public class PlacesController : Controller
    {
        // GET: Places/BusinessDetails
        
            private readonly IWebHostEnvironment _hostingEnvironment;

            public PlacesController(IWebHostEnvironment hostingEnvironment)
            {
                _hostingEnvironment = hostingEnvironment;
            }

            // GET: Places/BusinessDetails
            public IActionResult BusinessDetails()
            {
                // Define the path to the JSON file
                string jsonFilePath = Path.Combine(_hostingEnvironment.ContentRootPath, "wwwroot", "AppData", "data.json");
                string jsonData = System.IO.File.ReadAllText(jsonFilePath);

            JObject jsonObject = JsonConvert.DeserializeObject<JObject>(jsonData);

            if (jsonObject == null || !jsonObject.TryGetValue("Places", out JToken placesToken))
            {
                return NotFound("Business data could not be loaded.");
            }

            List<Place> places = placesToken.ToObject<List<Place>>();

            BusinessDirectoryViewModel viewModel = new BusinessDirectoryViewModel
            {
                Places = places
            };

            return View(viewModel);
        }
    }
}