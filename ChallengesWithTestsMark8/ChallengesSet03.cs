using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            bool temp = false;
            foreach(bool item in vals)
            {
                if (item == false)
                {
                    temp = true;
                }
            }
            return temp;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            int ans = 0;

            if(numbers == null)
            {
                return false;
            }

            foreach (int num in numbers)
            {
                if (Math.Abs(num) % 2 == 1)
                {
                    ans += num;
                }
            }
            
            if(Math.Abs(ans) % 2 == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool isLower = false;
            bool isUpper = false;
            bool isDigit = false;
            for(int i = 0; i < password.Length; i++)
            {
                if (Char.IsLower(password[i]))
                {
                    isLower = true;
                }
                if (Char.IsUpper(password[i]))
                {
                    isUpper = true;
                }
                if (Char.IsDigit(password[i]))
                {
                    isDigit = true;
                }
            }
            if (isLower && isUpper && isDigit)
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
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            int[] odds = {
                1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25,
                27, 29, 31, 33, 35, 37, 39, 41, 43, 45, 47, 49,
                51, 53, 55, 57, 59, 61, 63, 65, 67, 69, 71, 73,
                75, 77, 79, 81, 83, 85, 87, 89, 91, 93, 95, 97, 99
            };

            return odds;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for(int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
