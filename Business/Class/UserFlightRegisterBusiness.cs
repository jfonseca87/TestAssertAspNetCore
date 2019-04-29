using System.Collections.Generic;
using Business.Interfaces;
using Domain;
using Domain.DTOs;
using Repository.Interfaces;

namespace Business.Class
{
    public class UserFlightRegisterBusiness : IUserFlightRegisterBusiness
    {
        private readonly IUserFlightRegisterRepository userFlightRegisterRepository;
        private readonly IUserRepository userRepository;
        public UserFlightRegisterBusiness(IUserFlightRegisterRepository userFlightRegisterRepository,
                                          IUserRepository userRepository)
        {
            this.userFlightRegisterRepository = userFlightRegisterRepository;
            this.userRepository = userRepository;
        }

        public int SaveUserFlightRegister(int idFlight, int userDocumentNumber)
        {
            UserFlight user = userRepository.GetUserByDocument(userDocumentNumber);
            return userFlightRegisterRepository.SaveUserFlightRegister(idFlight, user.IdUser);
        }

        public IEnumerable<int> SaveUserFlightRegisterMassive(IEnumerable<UserFlightRegisterDTO> lstRecords)
        {
            List<int> lstSuccess = new List<int>(); 

            foreach (UserFlightRegisterDTO item in lstRecords)
            {
                UserFlight user = userRepository.GetUserByDocument(item.UserDocumentNumber);
                lstSuccess.Add(this.userFlightRegisterRepository.SaveUserFlightRegister(item.IdFlight, user.IdUser));
            }

            return lstSuccess;
        }
    }
}
