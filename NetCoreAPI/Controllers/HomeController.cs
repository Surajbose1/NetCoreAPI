using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetCoreAPI.Models;

namespace NetCoreAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        // GET: api/Home
        [HttpGet]
        [Route("[action]")]
        public IActionResult Action1()
        {
            return Ok("Auth covered");
        }


        // GET: api/Home
        [HttpGet]
        [Route("[action]")]
        public IActionResult Action2()
        {
            var productList = new List<Product>();
            for (int i=0; i < 2; i++)
            {
                var product = new Product()
                {
                    ProductId = Guid.NewGuid(),
                    ProductName = $"Product{i}",
                    Description = $"Product Description {i}",
                    Created = DateTime.Now.AddDays(-7)
                };

                productList.Add(product);
            }
            return Ok(productList);
        }

    }
}
