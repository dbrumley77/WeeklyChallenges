using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {


        public bool ArrayContainsAFalse(bool[] vals)
        {
            foreach (var val in vals)
            {
                if (val == false) return true;
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            //sum of all odd #s in list(IEnumerable)
            if (numbers == null)
            {
                return false;
            }
            int sum = 0;
            foreach (var val in numbers)
            {
                if (val % 2 != 0)
                {
                    sum += val;
                }

            }
            if (sum % 2 != 0) return true;
            else return false;


        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool isNumber = false;
            bool isUpper = false;
            bool isLower = false;
            foreach (char c in password)
            {
                if (char.IsNumber(c))
                {
                    isNumber = true;
                }
                if (char.IsUpper(c))
                {
                    isUpper = true;
                }
                if (char.IsLower(c))
                {
                    isLower = true;
                }

            }
            if (isNumber && isUpper && isLower)
            {
                return true;
            }
            else return false;

        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {

            int position = val.Length - 1;
            return val[position];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }
            decimal answer = dividend / divisor;
            return answer;
        }

        public int LastMinusFirst(int[] nums)
        {
            int position = nums.Length - 1;
            int last = nums[position];
            int first = nums[0];
            return last - first;

        }

        public int[] GetOddsBelow100()
        {
            List<int> nums = new List<int>();
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 != 0)
                {
                    nums.Add(i);
                }
            }
            return nums.ToArray();

        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            // words[0] = hello
            // words[0].ToUpper() -> HELLO
            for(int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
