using StepTrips.DataContract.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepTrips.DataContract.DTOs.Client_DTOs
{
    public class ReservationDTO
    {
        public int Id { get; set; }

        public int TripId { get; set; }
        public int ClientId { get; set; }
        public int TripTypesId { get; set; }
        public int PlaneId { get; set; }
        public int TripStatusId { get; set; }
        public int CountryId { get; set; }
        public int StatusId { get; set; }
        public bool Paid { get; set; }
       
    }
}
