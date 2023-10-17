using CarsAPI.DTOs;
using CarsAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System;


namespace CarsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private CarDbContext _context = new CarDbContext();
        private ResponseResult resultDto = new();
        [HttpGet]
        public ActionResult<ResponseResult> getCars()
        {
            try
            {
                var result = _context.Cares.ToList();

                if (result == null)
                {
                    resultDto.Message = "Sikertelen lekérdezés";
                    return NotFound(resultDto);
                }
                resultDto.Success = true;
                resultDto.Result = result;
                resultDto.Message = "Sikeres lekérdezés";

                return Ok(resultDto);
            }
            catch (Exception)
            {
                return BadRequest();
            }

        }

        [HttpGet("{guid}")]
        public ActionResult<ResponseResult> getCarById(Guid guid)
        {
            try
            {
                var result = _context.Cares.FirstOrDefault(item => item.Id == guid);

                if (result == null)
                {
                    resultDto.Message = "Sikertelen lekérdezés";
                    return NotFound(resultDto);
                }
                resultDto.Success = true;
                resultDto.Result = result;
                resultDto.Message = "Sikeres lekérdezés";

                return Ok(resultDto);
            }
            catch (Exception)
            {
                return BadRequest();
            }

        }

        [HttpDelete("/delete/{guid}")]
        public ActionResult<ResponseResult> deleteCarById(Guid guid)
        {
            try
            {
                var result = _context.Cares.FirstOrDefault(item => item.Id == guid);
                if (result == null)
                {
                    resultDto.Message = "Sikertelen törlés";
                    return NotFound(resultDto);
                }
                resultDto.Result = result;
                resultDto.Success = true;
                resultDto.Message = "Sikeres törlés";

                _context.Remove(result);
                _context.SaveChanges();

                return Ok(resultDto);
            }
            catch (Exception)
            {
                return BadRequest();
            }

        }

        [HttpPost]
        public ActionResult<ResponseResult> PostData(CreateCarDto createCarDto)
        {
            var car = new Car
            {
                Id = Guid.NewGuid(),
                Name = createCarDto.name,
                Description = createCarDto.desription,
                Color = createCarDto.color,
                CreatedDate = DateTime.Now,
            };

            if (car == null)
            {
                resultDto.Message = "Sikertelen hozzáadás";
                return NotFound(resultDto);
            }
            resultDto.Result = car;
            resultDto.Success = true;
            resultDto.Message = "Sikeres hozzáadás";

            _context.Cares.Add(car);
            _context.SaveChanges();


            return StatusCode(201,resultDto);
        }

        [HttpPut("update/{guid}")]
        public ActionResult<ResponseResult> updateData(Guid guid, UpdateCarDto update)
        {
            try
            {
                var result = _context.Cares.FirstOrDefault(item => item.Id == guid);

                if (result == null)
                {
                    resultDto.Message = "Sikertelen frissítés";
                    return NotFound(resultDto);
                }
                resultDto.Result = result;
                resultDto.Success = true;
                resultDto.Message = "Sikeres frissítés";

                result.Name = update.name;
                result.Color = update.color;
                result.Description = update.desription;

                _context.Update(result);
                _context.SaveChanges();

                return resultDto;
            }
            catch (Exception)
            {

                return BadRequest();
            }

        }
    }
}
