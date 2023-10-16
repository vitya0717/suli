using CarsAPI.DTOs;
using CarsAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace CarsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        [HttpPost]
        public ActionResult<Car> PostData(CreateCarDto createCarDto)
        {
            var car = new Car
            {
                Id = Guid.NewGuid(),
                Name = createCarDto.name,
                Description = createCarDto.desription,
                Color = createCarDto.color,
                CreatedDate = DateTime.Now,
            };
            using (var result = new CarDbContext())
            {
                result.Cares.Add(car);
                result.SaveChanges();
            }

            return Ok(car.AsDto());
        }
    }
}
