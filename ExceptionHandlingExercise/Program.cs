using System;
using System.Collections.Generic;
using System.IO;

namespace ExceptionHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            char[] arr = new char[] { '1', '2', '3', '4', '5', '6', 'a', 'b', 'c' };
            List<int> numbers = new List<int>();
            var str = "";

            foreach (var item in arr)
            {
                int number;
                try
                {
                    str = item.ToString();
                    number = int.Parse(str);
                    numbers.Add(number);
                }
                catch (Exception e)
                {

                }
            }

            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
