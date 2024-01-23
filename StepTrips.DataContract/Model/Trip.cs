using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StepTrips.DataContract.Model
{
    public class Trip
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Plane")]
        public int Plane { get; set; }
        [ForeignKey("TripStatusId")]
        public int TripStatusId { get; set; }
        public string TripFrom { get; set; }
        public string TripTo { get; set;}
        public string TripCode
        {
            get
            {
                
                string firstAlphabet = TripTime.DayOfWeek.ToString().Substring(0, 1);

                
                string datePart = TripTime.ToString("ddMMyyyy");

                
                string idPart = Id.ToString().PadLeft(3, '0');

                
                return $"{firstAlphabet}{datePart}{idPart}";
            }
        }
        public DateTime TripTime { get; set; }
        public decimal PriceOfEconomy { get; set; }
        public decimal PriceOfBusiness { get; set; }
        public virtual TripStatus TripStatus { get; set; }
        public Plane Planes { get; set; }

    }
}
