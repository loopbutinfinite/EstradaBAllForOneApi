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
    public class ReverseItAlphanumericController : ControllerBase
    {
        private readonly ReverseItAlphanumericService _ReverseItAlphanumericService;
        public ReverseItAlphanumericController(ReverseItAlphanumericService reverseItAlphanumericService)
        {
            _ReverseItAlphanumericService = reverseItAlphanumericService;
        }

        [HttpGet]
        [Route("Alphanumeric/{userInput}")]
        public string ReturnAlphanumericReversedinator(string userInput)
        {
            return _ReverseItAlphanumericService.AlphanumericReversed(userInput);
        }
    }
}