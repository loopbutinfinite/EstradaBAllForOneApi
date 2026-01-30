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
    public class GuessItController : ControllerBase
    {
        private readonly GuessItService _GuessItService;

        public GuessItController(GuessItService guessItService)
        {
            _GuessItService = guessItService;
        }

        [HttpGet]
        [Route("EasyMode/{userInput}")]
        public string ReturnEasyModeResultsinator(string userInput)
        {
            return _GuessItService.GuessItGameEasy(userInput);
        }

        [HttpGet]
        [Route("MediumMode/{userInputMed}")]
        public string ReturnMediumModeResultsinator(string userInputMed)
        {
            return _GuessItService.GuessItGameMedium(userInputMed);
        }

        [HttpGet]
        [Route("HardMode/{userInputHard}")]
        public string ReturnHardModeResultsinator(string userInputHard)
        {
            return _GuessItService.GuessItGameHard(userInputHard);
        }
    }
}