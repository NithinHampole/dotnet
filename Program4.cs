using System;
using System.Threading.Tasks;

namespace ProgramList
{
    class Program4
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Enter your Order Name:");
            string orderName = Console.ReadLine();

            await ProcessOrderAsync(orderName);
        }

        static async Task ProcessOrderAsync(string itemName)
        {
            Console.WriteLine("Processing Order...........");
            await Task.Delay(3000);
            Console.WriteLine($"Order for {itemName} is ready!");

        }
    }
}
