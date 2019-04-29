using Domain;
using Repository.Interfaces;

namespace Repository.Class
{
    public class UserFlightRegisterRepository : IUserFlightRegisterRepository
    {
        private readonly AssertContext context;
        public UserFlightRegisterRepository(AssertContext context)
        {
            this.context = context;
        }

        public int SaveUserFlightRegister(int idFlight, int idUser)
        {
            UserFlightRegister register = new UserFlightRegister
            {
                IdFlight = idFlight,
                IdUser = idUser
            };

            context.UserFlightRegister.Add(register);
            context.SaveChanges();

            return register.IdUserFlightRegister;
        }
    }
}
