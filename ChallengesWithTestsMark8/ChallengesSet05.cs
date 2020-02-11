using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            while((startNumber + 1) % n != 0)
            {
                startNumber++;
            }
            return startNumber + 1;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach(var business in businesses)
            {
                if(business.TotalRevenue == 0)
                {
                    business.Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            bool ans = true;
            if (numbers == null)
            {
                return false;
            }
            if (numbers.Length == 0)
            {
                return false;
            }
            
            for(int i = 0; i < numbers.Length - 1; i++)
            {
                if(numbers[i] <= numbers[i + 1])
                {
                    ans = true;
                }
                else
                {
                    ans = false;
                    break;
                }
            }
            return ans;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            int sum = 0;
            if(numbers == null)
            {
                return 0;
            }
            for(int i = 0; i < numbers.Length - 1; i++)
            {
                if(numbers[i] % 2 == 0)
                {
                    sum += numbers[i + 1];
                }
            }
            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null) return "";
            if (words.Length == 0) return "";

            var trimmed = new List<string>();
            foreach(var word in words)
            {
                if(!string.IsNullOrWhiteSpace(word))
                {
                    trimmed.Add(word.Trim());
                }
            }
            
            var ans = string.Join(" ", trimmed);
            if (string.IsNullOrWhiteSpace(ans))
            {
                return "";
            }
            else
            {
                return ans + ".";
            }
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            var fourthList = new List<double>();
            if (elements == null) return new double[0];
            for(int i = 0; i < elements.Count; i++)
            {
                if(elements[i] % 4 == 0)
                {
                    fourthList.Add(elements[i]);
                }
            }
            return fourthList.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            if (nums.Length == 1) return false;

            bool ans = false;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (i == j) continue;
                    if (nums[i] + nums[j] == targetNumber)
                    {
                        ans = true;
                    }
                    if (ans == true) break;
                }
                if (ans == true) break;
            }
            return ans;
        }
    }
}
