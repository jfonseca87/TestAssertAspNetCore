using Domain;

namespace Business.Interfaces
{
    public interface IFlightBusiness
    {
        Flight GetFlightById(int idFlight);
        int SaveFlight(Flight flight);
    }
}
