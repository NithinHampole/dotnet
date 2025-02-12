using System;
using System.Diagnostics;
using System.IO;

namespace ProgramList
{
    class SingleThread
    {
        static void Main()
        {
            Stopwatch stopwatch = Stopwatch.StartNew();

            string directoryPath = "SingleThread";
            Directory.CreateDirectory(directoryPath);

            byte[] dataBlock = new byte[50 * 1024];
            new Random().NextBytes(dataBlock);

            for (int i = 1; i <= 100; i++)
            {
                string fileName = Path.Combine(directoryPath, $"File_{i}.bin");
                using (FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write))
                {
                    for (int j = 0; j < 200; j++)
                    {
                        fs.Write(dataBlock, 0, dataBlock.Length);
                    }
                }
                Console.WriteLine($"{fileName} Writing Completed");
            }

            stopwatch.Stop();
            Console.WriteLine($"Single-threaded execution time: {stopwatch.ElapsedMilliseconds} ms");
        }
    }
}