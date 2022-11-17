using Microsoft.AspNetCore.Mvc;
using MyApi.Enums;
using MyApi.Models;
using MyApi.Service;

namespace MyApi.Controllers
{
    [Route("[action]")]
    [ApiController]
    public class MainController : ControllerBase
    {
        

        private ICarService _carService;
        private IBusService _busService;
        private IBoatService _boatService;
        public MainController(ICarService carService, IBusService busService, IBoatService boatService)
        {
            _carService = carService;
            _busService = busService;
            _boatService = boatService;
        }

        

        //• [GET] User should be able to select cars by color.
        //• [GET] User should be able to select buses by color.
        //• [GET] User should be able to select boats by color.
        //• [POST] User should be able to turn on/off headlights of the car by car’s ID.
        //• [DELETE] User should be able to delete the car.
        //  The code that selects the vehicles and returns it should be in a separate class (scoped service) and should be accessed by the controller using dependency injection. 

        [HttpGet("{color}")]
        public ActionResult GetCar(ColorEnum color)
        {
            var result = _carService.GetList(x => x.Color == color);
            return Ok(result);
        }

        [HttpGet("{color}")]
        public ActionResult GetBus(ColorEnum color)
        {
            var result = _busService.GetList(x => x.Color == color);
            return Ok(result);
        }
        [HttpGet("{color}")]
        public ActionResult GetBoat(ColorEnum color)
        {
            var result = _boatService.GetList(x => x.Color == color);
            return Ok(result);
        }

        [HttpPost("{carId}/{isOn}")]
        public ActionResult SetHeadlight(int carId, bool isOn)
        {
            
            var result = _carService.GetSingle(x => x.Id == carId);
            if (result.Data != null)
            {
                result.Data.Headlights = isOn;
                return Ok(_carService.Update(result.Data));
            }
            return Ok("Car is not exist");
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteCar(int id)
        {
            return Ok(_carService.Delete(id));
        }
    }
}