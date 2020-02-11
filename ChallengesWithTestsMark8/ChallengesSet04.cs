using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int evens = 0;
            int odds = 0;
            foreach(int num in numbers)
            {
                if(num % 2 == 0)
                {
                    evens += num;
                }
                if(num % 2 == 1)
                {
                    odds += num;
                }
            }
            return evens - odds;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            int shortest = str1.Length;
            var temp = new string[] { str1, str2, str3, str4 };

            foreach(string str in temp)
            {
                if(str.Length < shortest)
                {
                    shortest = str.Length;
                }
            }
            return shortest;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int smallest = number1;
            var temp = new int[] { number1, number2, number3, number4 };
            
            foreach(int num in temp)
            {
                if(num < smallest)
                {
                    smallest = num;
                }
            }
            return smallest;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 < 1 || sideLength2 < 1 || sideLength3 < 1)
            {
                return false;
            }
            else if (sideLength1 + sideLength2 > sideLength3 && 
                     sideLength1 + sideLength3 > sideLength2 && 
                     sideLength2 + sideLength3 > sideLength1)
            {
                return true;
            }
            else return false;
        }

        public bool IsStringANumber(string input)
        {
            return double.TryParse(input, out double i);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int nullCount = 0;
            foreach(object obj in objs)
            {
                if(obj == null)
                {
                    nullCount += 1;
                }
            }
            if ((objs.Length / 2) < nullCount)
            {
                return true;
            }
            else return false;
        }

        public double AverageEvens(int[] numbers)
        {
            double evens = 0;
            double evensCount = 0;

            if(numbers == null)
            {
                return 0;
            }

            foreach(int num in numbers)
            {
                if(num % 2 == 0)
                {
                    evens += num;
                    evensCount++;
                }
            }

            if (evensCount == 0)
            {
                return 0;
            }
            else 
            {
                return evens / evensCount;
            }
        }

        public int Factorial(int number)
        {
            int result = 1;

            if(number == 0)
            {
                return 1;
            }
            if(number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            while(number != 1)
            {
                result = result * number;
                number--;
            }

            return result;
        }
    }
}
