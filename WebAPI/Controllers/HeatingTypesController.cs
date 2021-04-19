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
    public class HeatingTypesController : ControllerBase
    {
        private IHeatingTypeService _heatingTypeService;

        public HeatingTypesController(IHeatingTypeService heatingTypeService)
        {
            _heatingTypeService = heatingTypeService;

        }

        [HttpPost("add")]
        public IActionResult Add(HeatingType heatingType)
        {
            var result = _heatingTypeService.Add(heatingType);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(HeatingType heatingType)
        {
            var result = _heatingTypeService.Delete(heatingType);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(HeatingType heatingType)
        {
            var result = _heatingTypeService.Update(heatingType);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }



        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _heatingTypeService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _heatingTypeService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
