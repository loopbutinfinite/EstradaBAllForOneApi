using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Services
{
    public class ReverseItNumbersOnlyService
    {
        public string ReversedNumberSequence(string userInput)
        {
            if (long.TryParse(userInput, out long userNumInput))
            {   
            long reversedNum = 0;
            for (long i = userNumInput; i > 0; i /= 10)
            {
                long lastDigit = i % 10;               
                reversedNum = (reversedNum * 10) + lastDigit;
            }
            return $"{userInput} reversed is {reversedNum}.";
            }
            return $"{userInput} was an invalid input. Please enter number values only.";
        }
    }
}