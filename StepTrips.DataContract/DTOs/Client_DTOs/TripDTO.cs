using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepTrips.DataContract.DTOs.Client_DTOs
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
