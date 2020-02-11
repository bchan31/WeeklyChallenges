using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            if (Char.IsLetter(c) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if(vals.Length % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberEven(int number)
        {
            if(number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberOdd(int num)
        {
            if(num % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        { 
            if(numbers == null)
            {
                return 0;
            }

            var numbersToList = new List<double>();
            foreach (var item in numbers)
            {
                numbersToList.Add(item);
            }

            if(numbersToList.Count == 0)
            {
                return 0;
            }

            double minNum = numbersToList[0];
            double maxNum = numbersToList[0];

            foreach (var item in numbersToList)
            {
                if(item < minNum)
                {
                    minNum = item;
                }
                if(item > maxNum)
                {
                    maxNum = item;
                }
            }

            return minNum + maxNum;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if(str1.Length < str2.Length)
            {
                return str1.Length;
            }
            else
            {
                return str2.Length;
            }
        }

        public int Sum(int[] numbers)
        {
            int sum = 0;
            if(numbers == null)
            {
                return 0;
            }
            foreach (int n in numbers)
            {
                sum += n;
            }
            return sum;
        }

        public int SumEvens(int[] numbers)
        {
            int sum = 0;
            if(numbers == null)
            {
                return 0;
            }
            foreach (int n in numbers)
            {
                if(n % 2 == 0)
                {
                    sum += n;
                }
            }
            return sum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            int sum = 0;
            if(numbers == null)
            {
                return false;
            }
            foreach (var item in numbers)
            {
                sum += item;
            }
            if(sum % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if(number < 0)
            {
                return 0;
            }
            else
            {
                return number / 2;
            }
        }
    }
}
