using System.Linq;
using Domain;
using Repository.Interfaces;

namespace Repository.Class
{
    public class UserRepository : IUserRepository
    {
        private readonly AssertContext context;
        public UserRepository(AssertContext context)
        {
            this.context = context;
        }

        public UserFlight GetUserByDocument(int documentNumber)
        {
            UserFlight user = context.UserFlight.FirstOrDefault(x => x.DocumentNumber == documentNumber);
            return user;
        }

        public int SaveUserFlight(UserFlight userFlight)
        {
            context.UserFlight.Add(userFlight);
            context.SaveChanges();

            return userFlight.IdUser;
        }
    }
}
