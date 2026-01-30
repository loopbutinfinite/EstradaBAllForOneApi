using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Services
{
    public class OddOrEvenService
    {
        public string OddOrEven(string input)
        {
            if (int.TryParse(input, out int num)){
                if (num % 2 == 0)
                {
                    return $"The number you gave {num}, is an even number";
                }
                else
                {
                    return $"The number you gave {num}, is an odd number";
                }
            }
            return "Invalid input. Please enter a whole integer.";
        }
    }
}