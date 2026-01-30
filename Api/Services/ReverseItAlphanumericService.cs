using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Services
{
    public class ReverseItAlphanumericService
    {
        public string AlphanumericReversed(string userInput)
        {
            string reversed = "";
            for (int i = userInput.Length - 1; i >= 0; i--)
            {
                reversed += userInput[i];
            }
            return reversed;
        }
    }
}