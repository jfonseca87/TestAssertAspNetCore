using Business.Interfaces;
using Domain;
using Repository.Interfaces;

namespace Business.Class
{
    public class UserBusiness : IUserBusiness
    {
        private readonly IUserRepository userRepository;
        public UserBusiness(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public UserFlight GetUserByDocument(int documentNumber)
        {
            UserFlight user = userRepository.GetUserByDocument(documentNumber);
            return user;
        }

        public int SaveUserFlight(UserFlight userFlight)
        {
            return userRepository.SaveUserFlight(userFlight);
        }
    }
}
