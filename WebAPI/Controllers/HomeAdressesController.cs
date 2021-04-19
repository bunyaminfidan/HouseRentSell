using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeAdressesController : ControllerBase
    {
        private IHomeAdressService _homeAdressService;

        public HomeAdressesController(IHomeAdressService homeAdressService)
        {
            _homeAdressService = homeAdressService;
        }

        [HttpPost("add")]
        public IActionResult Add(HomeAdress homeAdress)
        {
            var result = _homeAdressService.Add(homeAdress);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(HomeAdress homeAdress)
        {
            var result = _homeAdressService.Delete(homeAdress);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(HomeAdress homeAdress)
        {
            var result = _homeAdressService.Update(homeAdress);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }



        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _homeAdressService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _homeAdressService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
