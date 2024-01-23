using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using StepTrips.DataAccess;
using StepTrips.DataContract.Interface.Client_Interfaces;
using StepTrips.DataContract.Model;

namespace StepTripsreateC.Controllers;

public class ClientMainController : Controller
{
    #region Fields
    private readonly ApplicationDbContext _context;
    private readonly ISeatsCalculations _seatsCalculations;
    private readonly IClientAddReservation _clientAddReservation;

    #endregion

    #region Constructor
    public ClientMainController(ApplicationDbContext context,
        ISeatsCalculations seatsCalculations, IClientAddReservation clientAddReservation)
    {
        _context = context;
        _seatsCalculations = seatsCalculations;
        _clientAddReservation = clientAddReservation;
    }

    #endregion
    

    //Index Page
    #region Index Page
public ActionResult Index()
    {
        ViewBag.seatCalculation = _seatsCalculations.SeatsCalculations();

        ViewBag.Register = _context.Trips.ToList();

        ViewBag.Status = _context.TripStatuses.ToList();


        return View();
    }
    #endregion
    


    //Add Reservation
    #region Add Reservation
    public IActionResult AddReservationForClient()
    {
        var trips = _context.Trips.ToList();
        ViewBag.TripList = new SelectList(trips, "Id", "TripTo");
        var client = _context.Clients.ToList();
        ViewBag.ClientList = new SelectList(client, "Id", "FirstName" ,"LastName");
        return View();
    }


    [HttpPost]
    public IActionResult AddReservationForClient(ClientReservation clientReservation)
    {
        _context.ClientReservations.Add(clientReservation);
        _context.SaveChanges(); // Save changes to the database

        return RedirectToAction("Index");
    }

    #endregion        



    //Details
    #region Details Trip For Client
    public IActionResult MyTrip(int Id)
    {


        var tripDetails = _context.ClientReservations
    .Where(reservation => reservation.ClientId == Id)
    .Join(
        _context.Trips,
        reservation => reservation.TripId,
        trip => trip.Id,
        (reservation, trip) => new { Reservation = reservation, Trip = trip }
    )
    .FirstOrDefault();

        if (tripDetails == null)
        {
            return NotFound();
        }

        ViewBag.TripReservation = tripDetails.Reservation;

        return View(tripDetails.Trip);


    }
    #endregion
   
}


//public List<ReservationDTO> tr()
//{
//    var result = _context.TripReservation
//        .Join(_context.Trips,
//            tr => tr.TripId,
//            t => t.Id,
//            (tr, t) => new { TripReservation = tr, Trip = t })
//        .Join(_context.Clients,
//            combined => combined.TripReservation.ClientId,
//            c => c.Id,
//            (combined, c) => new { combined.TripReservation, combined.Trip, Client = c })
//        .Join(_context.TripTypes,
//            combined => combined.TripReservation.TripStatusId,
//            tt => tt.Id,
//            (combined, tt) => new { combined.TripReservation, combined.Trip, combined.Client, TripType = tt })
//        .Join(_context.Planes,
//            combined => combined.TripReservation.PlaneId,
//            p => p.Id,
//            (combined, p) => new { combined.TripReservation, combined.Trip, combined.Client, combined.TripType, Plane = p })
//        .Join(_context.Countries,
//            combined => combined.TripReservation.CountryId,
//            co => co.Id,
//            (combined, co) => new
//            {
//                combined.TripReservation,
//                combined.Trip,
//                combined.Client,
//                combined.TripType,
//                combined.Plane,
//                Country = co
//            })
//        .Join(_context.TripStatuses,
//            combined => combined.TripReservation.StatusId,
//            s => s.Id,
//            (combined, s) => new
//            {
//                combined.TripReservation,
//                combined.Trip,
//                combined.Client,
//                combined.TripType,
//                combined.Plane,
//                combined.Country,
//                Status = s
//            })
//        .Select(joined => new
//        {
//            // Access properties from joined entities here
//            ReservationId = joined.TripReservation.Id,
//            TripId = joined.Trip.Id,
//            // Add other properties you need similarly
//        })
//        .ToList();
//    return null;

//}
