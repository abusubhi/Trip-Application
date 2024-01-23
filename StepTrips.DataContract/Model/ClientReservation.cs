using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepTrips.DataContract.Model
{
    public class ClientReservation
    {
        [Key]   
        public int Id { get; set; }
        [ForeignKey("ClientId")]
        public int ClientId { get; set; }
        [ForeignKey("TripId")]
        public int TripId { get; set; }
        public bool Paid { get; set; }

        public Trip Trips { get; set; }
        public Client Clients { get; set; }
    }
}
