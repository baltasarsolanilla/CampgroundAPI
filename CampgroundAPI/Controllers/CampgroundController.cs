using CampgroundAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CampgroundAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CampgroundController : ControllerBase
    {
        private readonly DataContext _context;
        public CampgroundController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Campground>>> Get()
        {
            string campgroundsJSON = System.IO.File.ReadAllText("campspots.json");
            return Ok(campgroundsJSON);
        }
    }
}

