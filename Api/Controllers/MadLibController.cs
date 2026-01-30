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
    public class MadLibController : ControllerBase
    {
        private readonly MadLibService _MadLibService;
        public MadLibController(MadLibService madLibService)
        {
            _MadLibService = madLibService;
        }

        [HttpGet]
        [Route("MadLib/{name}/{occupation}/{unusualObject}")]
        public string MadlibStoryinator(string name, string occupation, string unusualObject)
        {
            return _MadLibService.MadlibStory(name, occupation, unusualObject);
        }
    }
}