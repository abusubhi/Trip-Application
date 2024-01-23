using AutoMapper;
using Microsoft.EntityFrameworkCore.Internal;
using StepTrips.DataContract.DTOs.Client_DTOs;
using StepTrips.DataContract.Model;

namespace TestHttpClient.Mapping
{
    public class MappingConfiguration : Profile
    {
        public MappingConfiguration()
        {
            CreateMap<Trip, TripDTO>();
            CreateMap<TripReservation, ReservationDTO>();
            CreateMap<ReservationDTO, TripReservation>();

            CreateMap<Client,ClientDTO>();

            CreateMap<Trip, TripDTO>()
                        .ForMember(dest => dest.TripCode, opt => opt.MapFrom(src => BuildTripCode(src)));
        }
        private string BuildTripCode(Trip trip)
        {
            string firstAlphabet = trip.TripTime.DayOfWeek.ToString().Substring(0, 1);
            string datePart = trip.TripTime.ToString("ddMMyyyy");
            string idPart = trip.Id.ToString().PadLeft(3, '0');

            return $"[{firstAlphabet}{datePart}{idPart}]";
        }
    }
}
