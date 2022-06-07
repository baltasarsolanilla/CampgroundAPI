using CampgroundAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CampgroundAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FavouriteController : ControllerBase
    {
        private static List<Campground> campgrounds = new List<Campground>
            {
                new Campground {
                    Id = 1,
                    Type = "Feature",
                    Geometry = new Geometry {  Id = 1 , Type = "Point",  Longitud = "-38.87767315100001", Latitud = "146.36428014600006"},
                    Property = new Property {
                        Id = 1,
                        ASSET_DESC = "Lower Barry Creek Campground",
                        ASSET_OWNE = "DELWP",
                        HERITAGE_V = "No",
                        MGA_EASTIN = "444857.0",
                        MGA_NORTHI = "5696606.0",
                        MGA_ZONE = "55",
                        PARK_ID = "3308.0",
                        PARK_NAME = "Wilsons Promontory National Park",
                        SITE_NAME = "Lower Barry Creek, Wilsons Promontory National Park",
                    }
                },
            };

        private readonly DataContext _context;

        public FavouriteController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Campground>>> Get()
        {
            string favouriteJSON = System.IO.File.ReadAllText("favourites.json");
            return Ok(favouriteJSON);
        }

    }
}
