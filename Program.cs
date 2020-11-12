using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace sortingByInsert
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] a = { 107, 7, 84, 3, 2 };
            //Console.WriteLine(BreakCamelCase("camelCase"))-
            //Console.WriteLine("camelCase".ToUpper());
            //List<int> list = new List<int> { 2, 3, 4, 5, 6 };
            //RemoveSmallest(list);
            //Console.WriteLine(list[0]);

            double[] arr = { 1, 2, 3, 4, 5, };
            Console.WriteLine(FindAverage(arr));
        }


        public static bool XO(string input)
        {
            return input.ToLower().Count(i => i == 'x') == input.ToLower().Count(i => i == 'o');

            //{
            //    char o = 'o';
            //    char O = 'O';
            //    char x = 'x';
            //    char X = 'X';

            //    int sumO = 0;
            //    int sumX = 0;

            //    for (int i = 0; i <= input.Length - 1; i++)
            //    {
            //        if (input[i] == o || input[i] == O)
            //        {
            //            sumO++;

            //        } else if (input[i] == x || input[i] == X)
            //        {
            //            sumX++;
            //        }
            //    }

            //    if (sumO == sumX)
            //    {
            //        Console.WriteLine("true");
            //        return true;
            //    }
            //    else if (sumO > sumX || sumX > sumO)
            //    {
            //        Console.WriteLine("false");
            //        return false;
            //    }
            //    else if (sumO == 0 && sumX == 0)
            //    {
            //        Console.WriteLine("false");
            //        return false;
            //    }
            //    else if (sumO == 0 || sumX == 0)
            //    {
            //        Console.WriteLine("false");
            //        return false;
            //    }
            //    else
            //    {
            //        return false;
            //    }
        }
        public static string HighAndLow(string numbers)
        {
            string[] res = numbers.Split(' ');

            int[] array = new int[res.Length];

            for (int i = 0; i <= res.Length - 1; i++)
            {
                array[i] = int.Parse(res[i]);
            }

            Array.Sort(array);

            return $"{array[0]} {array[array.Length - 1]}";
        }
        public static double basicOp(char operation, double value1, double value2)
        {
            switch (operation)
            {
                case '*':
                    return value1 * value2;
                case '+':
                    return value1 + value2;
                case '/':
                    return value1 / value2;
                case '-':
                    return value1 - value2;
            }


            return -1;
        }
        public static int FindSmallestInt(int[] args)
        {
            List<int> a = new List<int>();
            for (int i = 0; i <= args.Length - 1; i++)
                a.Add(args[i]);
            a.Min();
            return a.Min();
        }
        public static int sumTwoSmallestNumbers(int[] numbers)
        {
            List<int> a = new List<int>();
            for (int i = 0; i <= numbers.Length - 1; i++)
                a.Add(numbers[i]);
            int num1 = a.Min();
            a.Remove(num1);
            int num2 = a.Min();
            return num1 + num2;
        }
        public static int summation(int num)
        {
            int sum = 0;
            for (int i = 0; i <= num; i++)
                sum += i;
            return sum;
        }
        public static List<int> RemoveSmallest(List<int> numbers)
        {
            List<int> list = new List<int>();  
            numbers.Remove(numbers.Min());
            list = numbers;
            return list;
        }
        public static double FindAverage(double[] array)
        {
            if (array.Length > 0)
            {
                double sum = 0;
                for (int i = 0; i <= array.Length - 1; i++)
                {
                    sum += array[i];
                }

                return sum / array.Length - 1;
            }
            else {
                return 0;
            }
        }
    }
}
