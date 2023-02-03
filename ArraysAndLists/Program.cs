using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10

            /* Create two Lists of type int.
             * Name one List "evens"
             
             * Name the other List "odds"
             */

            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */

            /* Now using foreach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */

            //1-10 add even numbers to the even list.
            var evens = new List<int>();
            var odds = new List<int>();

            Console.WriteLine("Even Numbers: ");

            //even lists
            for (int i = 0; i <= 10; i+=2)
            {
                evens.Add(i);
            }
            foreach(int i in evens)
            {
                Console.WriteLine($"{i}");
            }

            Console.WriteLine("Odd Numbers: ");

            //1-10 add odds 
            for (int i = 1; i <= 10; i+=2)
            {
                odds.Add(i);

            }
            foreach (int i in odds)
            {
                Console.WriteLine($"{i}");
            }

        }
    }
}
