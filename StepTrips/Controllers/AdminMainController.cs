using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StepTrips.DataAccess;
using StepTrips.DataContract.Model;

namespace StepTrips.Controllers
{
    
    public class AdminMainController : Controller
    {
        private readonly ApplicationDbContext _context;
        public AdminMainController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var actions = new List<string> { "CreateClient", "CreatePlane", "CreateCountry",
                "CreateTrip", "CreateTripreservation", "CreateTripStatus", "CreateTripType" };
            return View(actions);
        }
        public IActionResult CreateClient()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateClient(Client Model)
        {
            var client = new Client { };
            _context.Clients.Add(Model);
            _context.SaveChanges();
            return View("Index");
        }

        public IActionResult CreatePlane()
        {
            return View();
        }

        public IActionResult CreateCountry()
        {
            return View();
        }

        public IActionResult CreateTrip()
        {
            return View();
        }

        public IActionResult CreateTripreservation()
        {
            return View();
        }

        public IActionResult CreateTripStatus()
        {
            return View();
        }

        public IActionResult CreateTripType()
        {
            return View();
        }
    }
}
