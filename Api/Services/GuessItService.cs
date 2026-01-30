using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Services
{
    public class GuessItService
    {
        public string GuessItGameEasy(string userInput)
        {
            if(int.TryParse(userInput, out int num)){
                Random randomEasy = new Random();
                int cpuEasyNum = randomEasy.Next(1, 11);
                if (num <= 0 || num > 10)
                {
                    return "Your guess was out of range. Guess a number between 1-10.";
                }
                else
                {
                    if (num > cpuEasyNum)
                    {
                        return $"Your guess {num} was higher than the CPU's guess.";
                    }
                    else if (num < cpuEasyNum)
                    {
                        return $"Your guess {num} was lower than the CPU's guess.";
                    }
                    else
                    {
                        return "You guessed correctly!!!";
                    }
                }
            }
            return"Invalid input. Please enter a valid number.";
        }
        public string GuessItGameMedium(string userInputMed)
        {
            if(int.TryParse(userInputMed, out int numMed)){
                Random randomMed = new Random();
                int cpuMedNum = randomMed.Next(1, 51);
                if (numMed <= 0 || numMed > 50)
                {
                    return "Your guess was out of range. Guess a number between 1-50.";
                }
                else
                {
                    if (numMed > cpuMedNum)
                    {
                        return $"Your guess {numMed} was higher than the CPU's guess.";
                    }
                    else if (numMed < cpuMedNum)
                    {
                        return $"Your guess {numMed} was lower than the CPU's guess.";
                    }
                    else
                    {
                        return "You guessed correctly!!!";
                    }
                }
            }
            return"Invalid input. Please enter a valid number.";
        }
        public string GuessItGameHard(string userInputHard)
        {
            if (int.TryParse(userInputHard, out int numHard))
            {
                Random randomHard = new Random();
                int cpuHardNum = randomHard.Next(1, 101);
                if (numHard <= 0 || numHard > 100)
                {
                    return "Your guess was out of range. Guess a number between 1-100.";
                }
                else
                {
                    if (numHard > cpuHardNum)
                    {
                        return $"Your guess {numHard} was higher than the CPU's guess.";
                    }
                    else if (numHard < cpuHardNum)
                    {
                        return $"Your guess {numHard} was lower than the CPU's guess.";
                    }
                    else
                    {
                        return "You guessed correctly!!!";
                    }
                }
            }
            return "Invalid input. Please enter a valid number.";
        }
    }
}