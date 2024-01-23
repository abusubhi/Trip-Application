
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StepTrips.DataAccess;
using StepTrips.DataContract.DTOs_Trip;
using StepTrips.DataContract.Interface;
using StepTrips.DataContract.Model;

namespace StepTrips.Controllers
{
    public class CreateClientController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IShowTrips _show;
        public CreateClientController(ApplicationDbContext context,IShowTrips show)
        {
            _context = context;
            _show = show;
        }
        public IActionResult CreateTrip()
        {
            TripDTO x = new TripDTO();
            //var trip = _show.CreateTrip().GetEnumerator;
            //return trip;
            var trip = _context.Trips;
            
            return View(trip);
        }

        public IActionResult Test()
        {
            return View() ;
        }
    }
}
