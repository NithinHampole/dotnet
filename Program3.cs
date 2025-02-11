using System;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace ProgramList
{
    class Program3
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> Student = new Dictionary<int, string>();
            bool flag = false;
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
                            int id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Student Name");
                            string name = Console.ReadLine();
                            Student.Add(id, name);
                            Console.WriteLine("\nStudent added Successfully\n");
                            flag = false;

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
                            Console.WriteLine("Enter Student ID in Numeric Value to Delete");
                            int Id = Convert.ToInt32(Console.ReadLine());

                            if (Student.Remove(Id))
                            {
                                Console.WriteLine("Student removed Successfully\n");
                            }
                            else
                            {
                                throw new KeyNotFoundException("\nStudent ID not found in the records.\n");

                            }

                            flag = false;

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
                        if (Student.Count == 0)
                        {
                            Console.WriteLine("\nNO Data Present");
                            break;
                        }
                        Console.WriteLine("Student Data\n");
                        foreach (var stu in Student)
                        {
                            Console.WriteLine($"ID:{stu.Key}\t\tName:{stu.Value}");
                        }
                        flag = false;
                        break;

                    case 4:
                        flag = true;
                        break;

                    default:
                        Console.WriteLine("\nYou have Entered Wrong Number");
                        flag = false;
                        break;
                }
            } while (flag != true);
        }
    }
}
