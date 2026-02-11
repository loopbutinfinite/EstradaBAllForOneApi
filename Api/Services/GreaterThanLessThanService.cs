using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Services
{
    public class GreaterThanLessThanService
    {
        public string ReturnStatements(string input1, string input2)
        {
            if (double.TryParse(input1, out double num1) && double.TryParse(input2, out double num2))
            {
                if(num1 > num2)
                {
                    return $"{num1} is greater than {num2}. {num2} is less than {num1}.";
                }
                else if (num1 < num2)
                {
                    return $"{num1} is less than {num2}. {num2} is greater than {num1}.";
                }
                else
                {
                    return $"{num1} is equal to {num2}. {num2} is equal to {num1}";
                }
            }
            return "That was an invalid input. Please enter a number.";
        }
    }
}