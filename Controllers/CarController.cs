using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestandoRepositoryPattern.Model;
using TestandoRepositoryPattern.Repository.Interface;

namespace TestandoRepositoryPattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarRepository _carRepository;

        public CarController(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        [HttpPost]
        public async Task<IActionResult> AddCar()
        {
            var car = new Car(Guid.NewGuid(), "Jeep", "SUV", 2022);
            await _carRepository.AddCar(car);
            
            return Ok(car);
        }
    }
}