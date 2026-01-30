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
    public class AskingQuestionsController : ControllerBase
    {
        private readonly AskingQuestionsService _AskingQuestionsService;
        public AskingQuestionsController(AskingQuestionsService askingQuestionsService)
        {
            _AskingQuestionsService = askingQuestionsService;
        }

        [HttpGet]
        [Route("Responses/{name}/{time}")]
        public string ReturnResponsesinator(string name, string time)
        {
            return _AskingQuestionsService.ReturnResponse(name, time);
        }
    }
}