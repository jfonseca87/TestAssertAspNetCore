using System;
using Business.Interfaces;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace AssertAPI.Controllers
{
    [ApiController]
    [Route("api/User")]
    public class UserController : ControllerBase
    {
        private readonly IUserBusiness userBusiness;
        public UserController(IUserBusiness userBusiness)
        {
            this.userBusiness = userBusiness;
        }

        [HttpGet("{userDocumentNumber}")]
        public IActionResult GetUserByDocumentNumber(int userDocumentNumber)
        {
            try
            {
                UserFlight user = userBusiness.GetUserByDocument(userDocumentNumber);
                return Ok(user);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        public IActionResult SaveUser(UserFlight user)
        {
            try
            {
                int response = userBusiness.SaveUserFlight(user);
                return Created("", response);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
