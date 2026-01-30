using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Services
{
    public class HelloWorldService
    {
        public string Greeting(string name)
        {
            return $"Hello {name}, Hope you are doing well today.";
        }
    }
}