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
    public class OddOrEvenController : ControllerBase
    {
        private readonly OddOrEvenService _OddOrEvenService;
        public OddOrEvenController(OddOrEvenService oddOrEvenService)
        {
            _OddOrEvenService = oddOrEvenService;
        }

        [HttpGet]
        [Route("Result/{input}")]
        public string OddOrEven(string input)
        {
            return _OddOrEvenService.OddOrEven(input);
        }
    }
}