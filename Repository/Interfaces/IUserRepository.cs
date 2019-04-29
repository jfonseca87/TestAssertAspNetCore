using Domain;

namespace Repository.Interfaces
{
    public interface IUserRepository
    {
        UserFlight GetUserByDocument(int documentNumber);
        int SaveUserFlight(UserFlight userFlight);
    }
}
