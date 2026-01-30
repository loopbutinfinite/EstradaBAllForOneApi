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
    public class Magic8BallController : ControllerBase
    {
        private readonly Magic8BallService _Magic8BallService;
        public Magic8BallController(Magic8BallService magic8BallService)
        {
            _Magic8BallService = magic8BallService;
        }

        [HttpGet]
        [Route("Magic8/{userQuestion}")]
        public string Magic8BallResponsinator(string userQuestion)
        {
            return _Magic8BallService.Magic8BallResponse(userQuestion);
        }
    }
}