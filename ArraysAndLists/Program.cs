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
            int[] myArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */
            List<int> evens = new List<int>();
            List<int> odds = new List<int>();
            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */
            foreach (int nums in myArray)
            {
                if (nums % 2 == 0)
                {
                    evens.Add(nums);
                }
                else
                {
                    odds.Add(nums);
                }
            }
            /* Now using foreach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */

            // Display Style 1:

            Console.WriteLine("The even numbers: ");
            foreach (int j in evens)
            {
                Console.WriteLine(j);
            }
            Console.WriteLine();
            Console.WriteLine("The odd numbers: ");
            foreach (int j in odds)
            {
                Console.WriteLine(j);
            }

            // Display Style 2:

            Console.WriteLine();
            for (int num = 0; num < odds.Count - 2; num+=3)
            {
                Console.WriteLine("The Odds: ");
                for (int oNum = odds.Count - 1; oNum >= 0; oNum--)
                {
                    if (odds[oNum] > 1)
                    {
                        Console.Write($"{odds[oNum]}, ");
                    }
                    else
                    {
                        Console.WriteLine(odds[oNum]);
                    }
                }
                Console.WriteLine();
                Console.WriteLine("The Evens");
                for (int oNum = evens.Count - 1; oNum >= 0; oNum--)
                {
                    if (odds[oNum] > 1)
                    {
                        Console.Write($"{evens[oNum]}, ");
                    }
                    else
                    {
                        Console.WriteLine(evens[oNum]);
                    }
                }
            }
        }
    }
}
