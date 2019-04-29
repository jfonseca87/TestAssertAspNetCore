using Domain;

namespace Repository.Interfaces
{
    public interface IFlightRepository
    {
        Flight GetFlightById(int idFlight);
        int SaveFlight(Flight flight);
    }
}
