using System;
using System.Linq;
using System.Collections.Generic;

namespace ProgramList
{
    class Program2
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter list of integers seperated by comas\n");
                List<int> inputList = Console.ReadLine().Split().Select(int.Parse).ToList();

                // 1.Numbers greater than 50

                var numberList = inputList.Where(num => num > 50).ToList();
                if (numberList.Count > 0)
                {
                    Console.WriteLine("\nNumbers Greater than 50 are..\n");
                    Console.WriteLine(string.Join('\t', numberList));
                }
                else
                {
                    Console.WriteLine("There are no Numbers Greater than 50 in the list");
                }

                // 2.Sorting Numbers

                var sortNumbers = inputList.OrderBy(num => num).ToList();
                Console.WriteLine("\nSorted list Numbers...\n");
                Console.WriteLine(string.Join("\t", sortNumbers));

                // 3.Squaring Numbers

                List<int> squaredNumber = new List<int>();
                foreach (int number in inputList)
                {
                    squaredNumber.Add(number * number);


                }
                Console.WriteLine("\nSquared Numbers...\n");
                foreach (int number in squaredNumber)
                {
                    Console.Write($"{number}\t");


                }
                Console.WriteLine("\n");
            }
            catch (FormatException e)
            {
                Console.WriteLine($"{e.Message} Please Enter only Integers with spaces");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}