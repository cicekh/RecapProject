using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concreate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarImagesController : ControllerBase
    {
        readonly ICarImageService _carImageService;

        public CarImagesController(ICarImageService carImageService)
        {
            _carImageService = carImageService;
        }


        [HttpPost("add")]
        public IActionResult Add([FromForm(Name = ("Image"))] IFormFile file, [FromForm] Photo carImage)
        {
            var result = _carImageService.Add(file, carImage);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update([FromForm(Name = "Image")] IFormFile file, [FromForm(Name = ("Id"))] int Id)
        {
            var carImages = _carImageService.GetById(Id).Data;
            var result = _carImageService.Update(file, carImages);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete([FromForm(Name = "Id")] int Id)
        {
            var carImage = _carImageService.GetById(Id).Data;
            var result = _carImageService.Delete(carImage);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _carImageService.GetAll();
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);

        }

        [HttpGet("getimages")]
        public IActionResult GetById(int carId)
        {
            var result = _carImageService.GetImagesOfACar(carId);
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);

        }
    }
}
