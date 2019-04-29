using System.Collections.Generic;
using Domain.DTOs;

namespace Business.Interfaces
{
    public interface IUserFlightRegisterBusiness
    {
        int SaveUserFlightRegister(int idFlight, int userDocumentNumber);
        IEnumerable<int> SaveUserFlightRegisterMassive(IEnumerable<UserFlightRegisterDTO> lstRecords);
    }
}
