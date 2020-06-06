using Microsoft.AspNetCore.Mvc;
using System;

namespace NetCoreAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get(string sortOrder)
        {
            switch (sortOrder)
            {
                case "asc":
                    //apply sort by ascending
                    break;
                case "desc":
                    //apply sort by descending
                    break;
                default:
                    break;
            }
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

        /// <summary>
        /// Implement paging
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="pageNumber"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("[action]")]
        public IActionResult PagingData(int pageSize, int pageNumber)
        {
            //var pagedData = data.Skip((pageNumber - 1) * pageSize).Take(pageSize);
            return Ok("paged data");
        }

        [HttpGet]
        [Route("[action]")]
        public IActionResult SearchData(string parameter)
        {
            //var filterData = data.Where(x=>x.Col.StartsWith(parameter));
            return Ok("filter data");
        }
    }
}