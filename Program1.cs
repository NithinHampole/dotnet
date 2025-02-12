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
            StringBuilder savedInput = new StringBuilder();
            bool stopFlag = true;
            try
            {
                while (stopFlag != false)
                {
                    string input = Console.ReadLine();
                    if (input.Contains("STOP"))
                    {
                        stopFlag = false;
                        break;
                    }
                    savedInput.AppendLine(input);
                }

                string filePath = @"C:\Users\Prodigy\Desktop\Read\output.txt";
                File.WriteAllText(filePath, savedInput.ToString());

                string fileContent = File.ReadAllText(filePath);
                Console.WriteLine("\nReading Content of file...\n");
                Console.WriteLine(fileContent);
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

