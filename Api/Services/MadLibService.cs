using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Services
{
    public class MadLibService
    {
        public string MadlibStory(string name, string occupation, string unusualObject)
        {
            return $"Yesterday, {name} was busy working as a professional {occupation} when they tripped over something hidden in the grass. Much to their surprise, it was a {unusualObject}! With no hesitation, they picked it up and realized they could have been the laughing stock of the company if anyone saw.";
        }
    }
}