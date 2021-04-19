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
    public class NeighborhoodsController : ControllerBase
    {
        private INeighborhoodService _neighborhoodService;

        public NeighborhoodsController(INeighborhoodService neighborhoodService)
        {
            _neighborhoodService = neighborhoodService;

        }
        [HttpPost("add")]
        public IActionResult Add(Neighborhood neighborhood)
        {
            var result = _neighborhoodService.Add(neighborhood);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Neighborhood neighborhood)
        {
            var result = _neighborhoodService.Delete(neighborhood);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Neighborhood neighborhood)
        {
            var result = _neighborhoodService.Update(neighborhood);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }



        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _neighborhoodService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _neighborhoodService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
