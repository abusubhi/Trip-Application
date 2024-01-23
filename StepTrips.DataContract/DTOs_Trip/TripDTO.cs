using StepTrips.DataContract.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepTrips.DataContract.DTOs_Trip
{
    public class TripDTO
    {
        public int Id { get; set; }
        public int Plane { get; set; }
        public string TripFrom { get; set; }
        public string TripTo { get; set; }
        public string TripCode { get; set; }
        public DateTime TripTime { get; set; }
        public decimal PriceOfEconomy { get; set; }
        public decimal PriceOfBusiness { get; set; }
    }
}
