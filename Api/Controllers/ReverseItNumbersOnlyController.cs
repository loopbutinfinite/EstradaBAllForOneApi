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
    public class ReverseItNumbersOnlyController : ControllerBase
    {
        private readonly ReverseItNumbersOnlyService _ReverseItNumbersOnlyService;
        public ReverseItNumbersOnlyController(ReverseItNumbersOnlyService reverseItNumbersOnlyService)
        {
            _ReverseItNumbersOnlyService = reverseItNumbersOnlyService;
        }

        [HttpGet]
        [Route("srebmuN/{userInput}")]
        public string ReversedNumberSequence(string userInput)
        {
            return _ReverseItNumbersOnlyService.ReversedNumberSequence(userInput);
        }
    }
}