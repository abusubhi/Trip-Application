using Microsoft.EntityFrameworkCore;
using StepTrips.DataContract.DTOs_Trip;
using StepTrips.DataContract.Interface;
using StepTrips.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StepTrips.DataContract.Model;
using AutoMapper;

namespace StepTrips.Business.Service
{
    public class ShowTrips:IShowTrips
    {
        private readonly IMapper _mapper;
        private readonly ApplicationDbContext _context;

        public ShowTrips(ApplicationDbContext context,IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }
        public Trip CreateTrip()
        {
            
            var x = _context.Trips;
            //var y = _mapper.Map<TripDTO>(x);
            return null ;
        }
    }
}
