using System;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace ProgramList
{
    class Program3
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> studentData = new Dictionary<int, string>();
            bool stopFlag = true;
            do
            {
                Console.WriteLine("----------------------------");
                Console.WriteLine("Enter the type of operation to be done");
                Console.WriteLine("1.Add a New Student\n2.Delete Student by Id\n3.Display all Students\n4.Exit\n");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        try
                        {
                            Console.WriteLine("Enter Student ID in Numeric Value");
                            int studentId = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Student Name");
                            string studentName = Console.ReadLine();
                            studentData.Add(studentId, studentName);
                            Console.WriteLine("\nStudent added Successfully\n");
                            stopFlag = true;

                        }
                        catch (ArgumentException e)
                        {
                            Console.WriteLine($"\nError:{e.Message} Student ID already exists\n");

                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine($"\nError:{e.Message} Student ID should be Numberic Value\n");

                        }
                        break;

                    case 2:
                        try
                        {
                            Console.WriteLine("\nEnter Student ID in Numeric Value to Delete");
                            int Id = Convert.ToInt32(Console.ReadLine());

                            if (studentData.Remove(Id))
                            {
                                Console.WriteLine("\nStudent removed Successfully\n");
                            }
                            else
                            {
                                throw new KeyNotFoundException("\nStudent ID not found in the records.\n");

                            }

                            stopFlag = true;

                        }
                        catch (KeyNotFoundException e)
                        {
                            Console.WriteLine($"Error: {e.Message}");
                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine($"\nError:{e.Message} Student ID should be Numberic Value\n");

                        }
                        break;

                    case 3:
                        if (studentData.Count == 0)
                        {
                            Console.WriteLine("\nNO Data Present");
                            break;
                        }
                        Console.WriteLine("\nStudent Data\n");
                        foreach (var stu in studentData)
                        {
                            Console.WriteLine($"ID:{stu.Key}\t\tName:{stu.Value}");
                        }
                        stopFlag = true;
                        break;

                    case 4:
                        stopFlag = false;
                        break;

                    default:
                        Console.WriteLine("\nYou have Entered Wrong Number");
                        stopFlag = true;
                        break;
                }
            } while (stopFlag == true);
        }
    }
}
