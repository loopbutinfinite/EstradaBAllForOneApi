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
    public class AddingTwoNumbersController : ControllerBase
    {
        private readonly AddingTwoNumbersService _AddingTwoNumbersService;
        public AddingTwoNumbersController(AddingTwoNumbersService addingTwoNumbersService)
        {
            _AddingTwoNumbersService = addingTwoNumbersService;
        }

        [HttpGet]
        [Route("Sum/{input1}/{input2}")]
        public string ReturnSuminator(string input1, string input2)
        {
            return _AddingTwoNumbersService.Adding(input1, input2);
        }
    }
}