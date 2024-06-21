using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet01
    {
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
            if(num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double Subtract(double minuend, double subtrahend)
        {
            double answer = minuend - subtrahend;
            return answer;
        }
        public int Add(int number1, int number2)
        {
            int answerAdd = number1 + number2;
            return answerAdd;
        }

        public int GetSmallestNumber(int number1, int number2)
        {
            if (number1 < number2)
            {
                return number1;
            }
            else
            {
                return number2;
            }
        }

        public long Multiply(long factor1, long factor2)
        {
            long answerMultiply = factor1 * factor2;
            return answerMultiply;
        }

        public string GetGreeting(string nameOfPerson)
        {
            
            if (nameOfPerson == "")
            {
                return "Hello!";
            }
            return ($"Hello, {nameOfPerson}!");
        }

        public string GetHey()
        {
            string greeting = "HEY!";
            return greeting;

            


        }
    }
}
