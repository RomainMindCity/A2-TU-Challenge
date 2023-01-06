using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge
{
    public class MyMathImplementation
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static bool IsMajeur(int age)
        {
            if (age < 0 || age > 140)
            {
                throw new ArgumentException();
            }
            return age >= 18;
        }

        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        public static bool IsDivisible(int number, int divisor)
        {
            return number % divisor == 0;
        }

        public static bool IsPrimary(int number)
        {
            if (number <= 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public static List<int> GetAllPrimary(int max)
        {
            List<int> result = new List<int>();
            for (int i = 2; i <= max; i++)
            {
                if (IsPrimary(i))
                {
                    result.Add(i);
                }
            }

            return result;
        }

        public static int Power2(int number)
        {
            return number * number;
        }

        public static int Power(int number, int power)
        {
            int result = 1;
            for (int i = 0; i < power; i++)
            {
                result *= number;
            }

            return result;
        }
        
        public static int IsInOrder(int a, int b)
        {
            if (a < b)
            {
                return 1;
            }
            else if (a > b)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        public static bool IsListInOrder(List<int> list)
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                if (IsInOrder(list[i], list[i + 1]) == -1)
                {
                    return false;
                }
            }

            return true;
        }

        public static List<int> Sort(List<int> list)
        {
            List<int> result = new List<int>(list);
            for (int i = 0; i < result.Count - 1; i++)
            {
                for (int j = i + 1; j < result.Count; j++)
                {
                    if (IsInOrder(result[i], result[j]) == -1)
                    {
                        int temp = result[i];
                        result[i] = result[j];
                        result[j] = temp;
                    }
                }
            }

            return result;
        }

        public static List<int> GenericSort(List<int> list, Func<int, int, int> compare)
        {
            List<int> result = new List<int>(list);
            for (int i = 0; i < result.Count - 1; i++)
            {
                for (int j = i + 1; j < result.Count; j++)
                {
                    if (compare(result[i], result[j]) == -1)
                    {
                        int temp = result[i];
                        result[i] = result[j];
                        result[j] = temp;
                    }
                }
            }

            return result;
        }

        public static int IsInOrderDesc(int a, int b)
        {
            return -IsInOrder(a, b);
        }
    }
}
