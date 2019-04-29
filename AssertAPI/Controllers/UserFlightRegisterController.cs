using System;
using System.Collections.Generic;
using Business.Interfaces;
using Domain.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace AssertAPI.Controllers
{
    [ApiController]
    [Route("api/UserFlightRegister")]
    public class UserFlightRegisterController : ControllerBase
    {
        private readonly IUserFlightRegisterBusiness userFlightRegisterBusiness;
        public UserFlightRegisterController(IUserFlightRegisterBusiness userFlightRegisterBusiness)
        {
            this.userFlightRegisterBusiness = userFlightRegisterBusiness;
        }

        [HttpPost]
        public IActionResult SaveUserFlight(UserFlightRegisterDTO userFlightRegister)
        {
            try
            {
                int response = userFlightRegisterBusiness.SaveUserFlightRegister(userFlightRegister.IdFlight, 
                                                                                 userFlightRegister.UserDocumentNumber);
                return Ok(response);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost("Massive")]
        public IActionResult SaveUserFlightMassive(IEnumerable<UserFlightRegisterDTO> lstRecords)
        {
            try
            {
                IEnumerable<int> lstResponses = userFlightRegisterBusiness.SaveUserFlightRegisterMassive(lstRecords);
                return Ok(lstResponses);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
