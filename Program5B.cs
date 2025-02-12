using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;

class MultiThreadedWriter
{
    static async Task Main()
    {
        Stopwatch stopwatch = Stopwatch.StartNew();

        string directoryPath = "MultiThread";
        Directory.CreateDirectory(directoryPath);

        byte[] dataBlock = new byte[50 * 1024];
        new Random().NextBytes(dataBlock);

        Task[] tasks = new Task[100];

        for (int i = 1; i <= 100; i++)
        {
            int fileNumber = i;
            tasks[i - 1] = Task.Run(async () =>
            {
                string fileName = Path.Combine(directoryPath, $"File_{fileNumber}.bin");
                using (FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None, 4096, useAsync: true))
                {
                    for (int j = 0; j < 200; j++)
                    {
                        await fs.WriteAsync(dataBlock, 0, dataBlock.Length);
                    }
                }
                Console.WriteLine($"{fileName} Writing Completed");
            });
        }

        await Task.WhenAll(tasks);

        stopwatch.Stop();
        Console.WriteLine($"Multi-threaded execution time: {stopwatch.ElapsedMilliseconds} ms");
    }
}
