using System;
using System.IO;
using System.Text;

namespace ProgramList
{
    class Program1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Input Text");
            StringBuilder SavedInput = new StringBuilder();
            bool flag = false;
            try
            {
                while (flag != true)
                {
                    string input = Console.ReadLine();
                    if (input.Contains("STOP"))
                    {
                        flag = true;
                        break;
                    }
                    SavedInput.AppendLine(input);
                }

                string Path = @"C:\Users\Prodigy\Desktop\Read\output.txt";
                File.WriteAllText(Path, SavedInput.ToString());

                string Content = File.ReadAllText(Path);
                Console.WriteLine("\nReading Content of file...");
                Console.WriteLine();
                Console.WriteLine(Content);
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine($"Error:{e.Message} You do not have permission to access the file ");
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine($"Error:{e.Message} Check your Directory");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error:{e.Message}");
            }

        }
    }

}

