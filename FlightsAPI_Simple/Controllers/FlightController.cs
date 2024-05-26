using FlightsAPI_Simple.Models;
using FlightsAPI_Simple.Services;
using Microsoft.AspNetCore.Mvc;

namespace FlightsAPI_Simple.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    //example: http://localhost:5609/api/flight/
    public class FlightController : ControllerBase
    {
        private readonly IFlightService _flightService;
        public FlightController(IFlightService flightService)
        {
            _flightService = flightService;
        }

        [HttpGet]
        public ActionResult<List<Flight>> GetAllFlights()
        {
            return Ok(_flightService.GetAllFlights());
        }

        [HttpGet("{id}")]
        public ActionResult<Flight> GetAllFlightById(int id)
        {
            return Ok(_flightService.GetFlightById(id));
        }

        [HttpPost]
        public ActionResult<Flight> CreateFlight(Flight flight) 
        {
            return Ok(_flightService.CreateFlight(flight));
        }

        [HttpPut("{id}")]
        public ActionResult<Flight> UpdateFlight(int id, Flight updatedFlight) 
        {
             return Ok(_flightService.UpdateFlight(id, updatedFlight));    
        }

        [HttpDelete("{id}")]
        public ActionResult<string> DeleteFlight (int id) 
        {
             return Ok(_flightService.DeleteFlight(id));
        }
    }
}