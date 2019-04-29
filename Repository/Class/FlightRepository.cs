using System.Linq;
using Domain;
using Repository.Interfaces;

namespace Repository.Class
{
    public class FlightRepository : IFlightRepository
    {
        private readonly AssertContext context;
        public FlightRepository(AssertContext context)
        {
            this.context = context;
        }
        public Flight GetFlightById(int idFlight)
        {
            Flight flight = context.Flight.FirstOrDefault(x => x.IdFlight == idFlight);
            return flight;
        }

        public int SaveFlight(Flight flight)
        {
            context.Flight.Add(flight);
            context.SaveChanges();

            return flight.IdFlight;
        }
    }
}
