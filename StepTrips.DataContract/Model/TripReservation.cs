using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StepTrips.DataContract.Model
{
    public class TripReservation
    {
        [Key]
        public int Id { get; set; }

        //[ForeignKey("TripId")]
        public int TripId { get; set; }

        [ForeignKey("ClientId")]
        public int ClientId { get; set; }

        [ForeignKey("PlaneId")]
        public int PlaneId { get; set; }

        [ForeignKey("TripTypeId")] 
        public int TripTypesId { get; set; }

        [ForeignKey("CountryId")]
        public int CountryId { get; set; }

        [ForeignKey("StatusId")]
        public int StatusId { get; set; }

        public bool Paid { get; set; }

        public virtual TripStatus TripStatus { get; set; }
        //public virtual Trip Trips { get; set; }
        public virtual Client Clients { get; set; }
        public virtual TripType TripTypes { get; set; }
        public virtual Plane Planes { get; set; }
        public virtual Country Countries { get; set; }



    }
}
