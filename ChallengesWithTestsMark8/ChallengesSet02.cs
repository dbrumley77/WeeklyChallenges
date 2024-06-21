using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            if (char.IsLetter(c))
            {
                return true;
            }
            return false;
        }

        
        public bool CountOfElementsIsEven(string[] vals)
        {
            bool isEven = (vals.Length % 2 == 0) ? true : false;
            return isEven;
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            return false;
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 != 0)
            {
                return true;
            }
            return false;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            
            if (numbers == null || numbers.Count() == 0)
            {
                return 0;
            }
            else
            {
                return numbers.Min() + numbers.Max();
            }
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length < str2.Length)
            {
                return str1.Length;
            }
            return str2.Length;
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            return numbers.Sum();
        }
        
        public int SumEvens(int[] numbers)
        {

           
            if (numbers == null)
            {
                return 0;
            }
            else
            {
                return numbers.Where(x => x % 2 == 0).Sum();
            }
        }

        public bool IsSumOdd(List<int> numbers)
        {
            

            if (numbers == null)
            {
                return false;
            }
            else
            {
                bool isSum = (numbers.Sum() % 2 == 0) ? false : true;
                return isSum;
            }
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            long count = 0;
            for (long i = 0; i < number; i++)
            {
                if (i % 2 != 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
