using StepTrips.DataAccess;
using StepTrips.DataContract.Interface.Client_Interfaces;

namespace StepTrips.Business.Service.Client_Implementation;

public class SeatsCalculation:ISeatsCalculations
{
    private readonly ApplicationDbContext _context;

    public SeatsCalculation(ApplicationDbContext context)
    {
        _context = context;
    }
    #region Calculation For Seats
    public int SeatsCalculations()
    {

        int totalSeats = _context.Planes.Where(e => e.Id == 1).Sum(p => p.BusinessSeats + p.EconomySeats);
        int totalReservations = _context.TripReservations.Count(e => e.TripId == 1);
        return totalSeats - totalReservations;
    }

    #endregion
}
