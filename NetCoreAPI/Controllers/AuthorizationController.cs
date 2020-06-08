using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetCoreAPI.Models;
using Newtonsoft.Json;

namespace NetCoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorizationController : ControllerBase
    {
        private readonly IHttpClientFactory _clientFactory;
        public AuthorizationController(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

       [HttpPost]
       [Route("[action]")]
       public IActionResult SignUpUser(Signup signupModel)
        {
            var jsonString = JsonConvert.SerializeObject(signupModel);
            var request = new HttpClient().PostAsync("https://dev-uslrkkz5.au.auth0.com/dbconnections/signup",
                new StringContent(jsonString, Encoding.UTF8, "application/json"));

            var response = request.Result.Content.ReadAsStringAsync();
            var deserialisedOutput = JsonConvert.DeserializeObject<SignupResponseModel>(response.Result);
            return Ok(deserialisedOutput);
        }

        [HttpPost]
        [Route("[action]")]
        public IActionResult GetToken(TokenInput tokenInput)
        {
            var jsonString = JsonConvert.SerializeObject(tokenInput);
            var request = new HttpClient().PostAsync("https://dev-uslrkkz5.au.auth0.com/oauth/token",
                new StringContent(jsonString, Encoding.UTF8, "application/json"));

            var response = request.Result.Content.ReadAsStringAsync();
            var deserialisedOutput = JsonConvert.DeserializeObject<TokenInputResponseModel>(response.Result);
            return Ok(deserialisedOutput);
        }
    }
}
