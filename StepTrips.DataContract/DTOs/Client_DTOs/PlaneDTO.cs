using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepTrips.DataContract.DTOs.Client_DTOs
{
    public class PlaneDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public int BusinessSeats { get; set; }
        public int EconomySeats { get; set; }
    }
}
