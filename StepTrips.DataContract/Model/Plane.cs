using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepTrips.DataContract.Model
{
    public class Plane
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public int BusinessSeats { get; set; }
        public int EconomySeats { get; set; }
    }
}
