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
    public class GreaterThanLessThanController : ControllerBase
    {
        private readonly GreaterThanLessThanService _GreaterThanLessThanService;
        public GreaterThanLessThanController(GreaterThanLessThanService greaterThanLessThanService)
        {
            _GreaterThanLessThanService = greaterThanLessThanService;
        }

        [HttpGet]
        [Route("Result/{input1}/{input2}")]
        public string GreaterThanLessThan(string input1, string input2)
        {
            return _GreaterThanLessThanService.ReturnStatements(input1, input2);
        }
    }
}