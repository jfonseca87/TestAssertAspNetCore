using Business.Interfaces;
using Domain;
using Repository.Interfaces;

namespace Business.Class
{
    public class FlightBusiness : IFlightBusiness
    {
        private readonly IFlightRepository flightRepository;

        public FlightBusiness(IFlightRepository flightRepository)
        {
            this.flightRepository = flightRepository;
        }

        public Flight GetFlightById(int idFlight)
        {
            Flight flight = flightRepository.GetFlightById(idFlight);
            return flight;
        }

        public int SaveFlight(Flight flight)
        {
            return flightRepository.SaveFlight(flight);
        }
    }
}
