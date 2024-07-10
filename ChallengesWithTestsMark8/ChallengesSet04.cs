using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    sum += number;
                }
                else
                {
                    sum -= number;
                }
                
            }
            return sum;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            // get length of all 4 strings
            int length1 = str1.Length;
            int length2 = str2.Length;
            int length3 = str3.Length;
            int length4 = str4.Length;
            int shortest1 = 0; // applies to lengths 1 and 2
            int shortest2 = 0; // applies to lengths 3 and 4
            //(condition) ? true : false
            shortest1 = (length1 > length2) ? length2 : length1;
            shortest2 = (length3 > length4) ? length4 : length3;

           return (shortest1 > shortest2) ? shortest2 : shortest1;
            
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int smallestNum1 = 0;
            int smallestNum2 = 0;
            smallestNum1 = (number1 > number2) ? number2 : number1;
            smallestNum2 = (number3 > number4) ? number4 : number3;
            return (smallestNum1 >  smallestNum2) ? smallestNum2 : smallestNum1;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
                        
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            int length1 = sideLength1;
            int length2 = sideLength2;
            int length3 = sideLength3;
            if ((length1 + length2) > length3 && (length2 + length3) > length1 && (length3 + length1) > length2)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool IsStringANumber(string input)
        {
            // check if string input is a number
            
            if (input == null || input.Length == 0)
            {
                return false;
            }
            foreach (var c in input)
            {
                if (c == '.' || c == '-')
                {
                    continue;
                }
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            
            List<object> elementsNull = new List<object>();
            List<object> elementsNotNull = new List<object>();

            foreach (var obj in objs)
            {
                if (obj == null)
                {
                    elementsNull.Add(obj);
                }
                else
                {
                    elementsNotNull.Add(obj);
                }
            }
            if (elementsNull.Count() > elementsNotNull.Count())
            {
                return true;
            }
            else return false;
            
        }

        public double AverageEvens(int[] numbers)
        {
            double average = 0;
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }


            // numbers -> get all even numbers
            List<int> evens = new List<int>();

            foreach (var n in numbers)
            {
                if (n % 2 == 0)
                {
                    evens.Add(n);
                }
            }

            if (evens.Count() == 0)
            {
                return 0;
            }
            
            average = evens.Average();
            return average;

            


        }

        public int Factorial(int number)
        {
            int factorial = 1;
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
