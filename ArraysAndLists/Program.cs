using System;
using System.Collections.Generic;
using System.Linq;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an int Array and populate numbers 1-10

            Console.WriteLine("Create an int Array and populate numbers 1-10 \n" );            
            int[] numRange10 = Enumerable.Range(1, 10).ToArray();
            foreach (int number in numRange10)
            {
                Console.WriteLine($"{number}");
            }           

            //Create two Lists of type int. name them even and odd.
            Console.WriteLine("\nCreate two Lists of type int. Name one List \"evens\" Name the other List \"odds\" \n");
            List<int> evens = new List<int>();
            List<int> odds = new List<int>();

            //Check for odd or even. add to correct list.
            Console.WriteLine("Using either a foreach or for loop, nest an if statement to check to see if a number is even or odd. Then add those numbers to either the evens List or the odds List \n");
            
            foreach (int number in numRange10)
            {
                if (number % 2 == 0) 
                {
                    evens.Add(number);                
                }
                else
                {
                    odds.Add(number);
                }
            }

            //Display new list
            Console.WriteLine("Now using foreach or for loops, display each List of even and odd numbers. Try to be creative in your display \n");
            Console.WriteLine($"the numbers in the odds list are as follows\n");
            foreach (int number in odds)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine($"the numbers in the evens list are as follows\n");
            foreach (int number in evens)
            {
                Console.WriteLine(number);  
            }
        }
    }
}
