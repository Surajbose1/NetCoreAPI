using Microsoft.AspNetCore.Mvc;
using System;

namespace NetCoreAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Data OK");
        }


        [HttpGet("{id:int}",Name ="Get")]
        public IActionResult GetById(int id)
        {
            return Ok("Data OK " + id);
        }

        [HttpGet("{id:alpha}", Name = "Get1")]
        public IActionResult GetByIdString(string id)
        {
            return Ok("Data OK " + id);
        }

        [HttpGet("{id:guid}", Name = "Get2")]
        public IActionResult GetByIdString(Guid id)
        {
            return Ok("Data OK " + id);
        }


    }
}