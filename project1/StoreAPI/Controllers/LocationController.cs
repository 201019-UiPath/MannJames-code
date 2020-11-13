using System;
using Microsoft.AspNetCore.Mvc;
using StoreLib;
using StoreDB.Models;
using StoreDB.Repos;

namespace StoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : Controller
    {
        private readonly ILocationService locationService;

        public LocationController(ILocationService locationService)
        {
            this.locationService = locationService;
        }

        [HttpPost("add")]
        [Consumes("application/json")]
        [Produces("application/json")]
        public IActionResult AddLocation(Location location)
        {
            try
            {
                locationService.AddLocation(location);
                return CreatedAtAction("AddLocation", location);

            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpPut("edit")]
        [Consumes("application/json")]
        [Produces("application/json")]
        public IActionResult UpdateLocation(Location location)
        {
            try
            {
                locationService.UpdateLocation(location);
                return CreatedAtAction("UpdateLocation", location);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpDelete("delete")]
        [Consumes("application/json")]
        [Produces("application/json")]
        public IActionResult DeleteLocation(Location location)
        {
            try
            {
                locationService.DeleteLocation(location);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpGet("getAll")]
        [Produces("application/json")]
        public IActionResult GetAllLocations()
        {
            try
            {
                return Ok(locationService.GetAllLocations());
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }
    }
}