using StepTrips.DataContract.DTOs.Client_DTOs;
using StepTrips.DataContract.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepTrips.DataContract.Interface.Client_Interfaces
{
    public interface IClientAddReservation
    {
        //IEnumerable<TripDTO> GetTripDTO();
        IEnumerable<ClientDTO> GetClientDTO();
        void AddReservationForClient(ClientReservation clientReservation);
    }
}
