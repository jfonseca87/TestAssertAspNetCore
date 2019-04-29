using System;
using Business.Interfaces;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace AssertAPI.Controllers
{
    [ApiController]
    [Route("api/Flight")]
    public class FlightController : ControllerBase
    {
        private readonly IFlightBusiness flightBusiness;
        public FlightController(IFlightBusiness flightBusiness)
        {
            this.flightBusiness = flightBusiness;
        }

        [HttpGet("{idFlight}")]
        public IActionResult GetFlightById(int idFlight)
        {
            try
            {
                Flight flight = flightBusiness.GetFlightById(idFlight);
                return Ok(flight);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        public IActionResult SaveFlight(Flight flight)
        {
            try
            {
                int response = flightBusiness.SaveFlight(flight);
                return Created("", response);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
