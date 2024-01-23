using StepTrips.DataContract.DTOs.Client_DTOs;
using StepTrips.DataContract.Model;


namespace StepTrips.DataContract.Interface.Client_Interfaces
{
    public interface IRegistrationWithTrip
    {
        List<ReservationDTO> RegistrationClientWithTrip();
    }
}
