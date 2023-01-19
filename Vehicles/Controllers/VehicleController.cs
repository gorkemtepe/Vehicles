using Microsoft.AspNetCore.Mvc;
using Vehicles.Core.Entities;
using Vehicles.Core.Repository;

namespace Vehicles.Controllers
{
    [Route("api/controller")]
    [ApiController]
    public class VehicleController:ControllerBase
    {
        private readonly VehicleRepository _repo;

        public VehicleController(VehicleRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        [Route("cars/{color}")]
        public ActionResult<List<Car>> GetCarsByColor(string color)
        {
            var cars = _repo.GetCarsByColor(color).ToList();
            return cars;
        }

        [HttpGet]
        [Route("buses/{color}")]
        public ActionResult<List<Bus>> GetBusesByColor(string color)
        {
            var buses = _repo.GetBusesByColor(color).ToList();
            return buses;
        }

        [HttpGet]
        [Route("boats/{color}")]
        public ActionResult<List<Boat>> GetBoatsByColor(string color)
        {
            var boats = _repo.GetBoatsByColor(color).ToList();
            return boats;
        }

        [HttpPost]
        [Route("cars/{id}/headlights")]
        public ActionResult TurnOnOffHeadlights(int id)
        {
            _repo.TurnOnOffHeadlights(id);
            return Ok();
        }

        [HttpDelete]
        [Route("cars/{id}")]
        public ActionResult DeleteVehicle(int id)
        {
            _repo.DeleteVehicle(id);
            return Ok();
        }
    }
}
