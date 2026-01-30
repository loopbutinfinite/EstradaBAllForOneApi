using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloWorldController : ControllerBase
    {
        private readonly HelloWorldService _HelloWorldService;
        public HelloWorldController(HelloWorldService helloWorldService)
        {
            _HelloWorldService = helloWorldService;
        }

        [HttpGet]
        [Route("Greeting/{name}")]
        public string ReturnGreetinginator(string name)
        {
            return _HelloWorldService.Greeting(name);
        }
    }
}