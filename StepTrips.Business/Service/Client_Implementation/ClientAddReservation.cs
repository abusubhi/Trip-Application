using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StepTrips.DataAccess;
using StepTrips.DataContract.DTOs.Client_DTOs;
using StepTrips.DataContract.Interface.Client_Interfaces;
using StepTrips.DataContract.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepTrips.Business.Service.Client_Implementation
{
    public class ClientAddReservation : IClientAddReservation
    {
        #region Fields
        private readonly IMapper _mapper;
        private readonly ApplicationDbContext _context;
        #endregion

       

        #region Constructor
        public ClientAddReservation(ApplicationDbContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }

        #endregion



        #region GetTrip
        //public IEnumerable<TripDTO> GetTripDTO()
        //{
            
        //    var trips = _context.Trips.ToList();
        //    var tripDTO = _mapper.Map<TripDTO>(trips);
        //    yield return tripDTO;
        //}
        #endregion


        #region GetClientDTO
        public IEnumerable<ClientDTO> GetClientDTO()
        {
            var client = _context.Clients.ToList();
            ClientDTO clientDTO = _mapper.Map<ClientDTO>(client);
            yield return clientDTO;
        }
        #endregion



        #region AddReservationForClient
        public void AddReservationForClient(ClientReservation clientReservation)
        {
            _context.ClientReservations.Add(clientReservation);
            _context.SaveChanges(); 

        }
        #endregion
        





        //public ClientDTO AddReservationForClient(int Id)
        //{
        //    var client = _context.Clients.FirstOrDefault(e => e.Id == Id);
        //    var clientDTO = _mapper.Map<ClientDTO>(client);

        //    return clientDTO;
        //}

        //public ReservationDTO AddReservationForClient(ReservationDTO model)
        //{
        //    if (model != null)
        //    {
        //        var tripReservation = _mapper.Map<TripReservation>(model);

        //        _context.TripReservations.Add(tripReservation);
        //        _context.SaveChanges();
        //    }
        //    throw new NotImplementedException();
        //}

    }

}

