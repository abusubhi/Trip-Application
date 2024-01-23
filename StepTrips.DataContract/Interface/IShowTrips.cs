using StepTrips.DataContract.DTOs_Trip;
using StepTrips.DataContract.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepTrips.DataContract.Interface
{
    public interface IShowTrips
    {
        Trip CreateTrip();
    }
}
