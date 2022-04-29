using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {

            var myArray = new Array[11];
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine((int)i);
            }

            Console.WriteLine("\n ");


            Console.WriteLine($"Please enter a number: ");
            var number = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");
           
            var evens = new List<int>();
            var odds = new List<int>();

            for (int i = 1; i <= number; ++i)
            {
                if (number % 2 == 0)
                {
                    i += 1;
                    Console.WriteLine("Even: ");
                    Console.WriteLine(i);
                    evens.Add(i);
                }
                else
                {
                    Console.WriteLine("Odd: ");
                    Console.WriteLine(i);
                    i += 1;
                    odds.Add(i);
                }
            }

            Console.WriteLine(" ");
            if (number % 2 == 0)
            {
                Console.WriteLine($"These are all the even numbers of {number}");
                evens.ForEach(Console.WriteLine);
            }

            if (number % 2 != 0)
            {
                Console.WriteLine($"These are all the even numbers of {number}");
            }
            foreach (var odd in odds)
            {
                Console.WriteLine($"{odd - 1}");
            }
        }
    }
}
