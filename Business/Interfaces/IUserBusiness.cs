using Domain;

namespace Business.Interfaces
{
    public interface IUserBusiness
    {
        UserFlight GetUserByDocument(int documentNumber);
        int SaveUserFlight(UserFlight userFlight);
    }
}
