using System.Diagnostics;

namespace Api.Async_and_Await_in.Asynchronous_example
{
    public class AsynchronousExample
    {
        public static async Task Start()
        {
            // Create a Stopwatch instance
            Stopwatch stopwatch = new Stopwatch();

            // Start the stopwatch
            stopwatch.Start();

            await CookMealAsynchronously();

            // Stop the stopwatch
            stopwatch.Stop();

            // Get the elapsed time in seconds
            TimeSpan elapsed = stopwatch.Elapsed;

            Console.WriteLine($"Elapsed Time (Seconds): {elapsed.TotalSeconds} s");
            Console.ReadLine();
        }
        private static async Task CookMealAsynchronously()
        {
            Console.WriteLine("Cooking meal asynchronously...");

            // We can now concurrently perform these tasks
            Task boilWaterTask = BoilWaterAsynchronously();
            Task cutVegetablesTask = CutVegetablesAsynchronously();

            // Await the completion of both tasks
            await Task.WhenAll(boilWaterTask, cutVegetablesTask);

            await CompleteOtherCookingAsynchronously();
        }

        private static async Task BoilWaterAsynchronously()
        {
            Console.WriteLine("Boiling water...");
            await Task.Delay(3000); // Simulating an asynchronous task
            Console.WriteLine("Water is hot!");
        }

        private static async Task CutVegetablesAsynchronously()
        {
            Console.WriteLine("Chopping vegetables...");
            await Task.Delay(3000); // Simulating an asynchronous task
            Console.WriteLine("Vegetables are ready!");
        }

        private static async Task CompleteOtherCookingAsynchronously()
        {
            Console.WriteLine("Adding Seasonings...");
            Console.WriteLine("Tasting for salt...");
            Console.WriteLine("Cooking for 5 seconds");

            await Task.Delay(5000);
            Console.WriteLine("Done cooking!");
        }
    }
}
