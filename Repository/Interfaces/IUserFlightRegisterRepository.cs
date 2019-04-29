namespace Repository.Interfaces
{
    public interface IUserFlightRegisterRepository
    {
        int SaveUserFlightRegister(int idFlight, int idUser);
    }
}
