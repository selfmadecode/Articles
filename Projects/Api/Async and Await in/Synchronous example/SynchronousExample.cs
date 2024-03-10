using System.Diagnostics;

namespace Api.Async_and_Await_in.Synchronous_example
{
    public static class SynchronousExample
    {
        public static void Start()
        {
            // Create a Stopwatch instance
            Stopwatch stopwatch = new Stopwatch();

            // Start the stopwatch
            stopwatch.Start();

            CookMealSynchronously();

            // Stop the stopwatch
            stopwatch.Stop();

            // Get the elapsed time in seconds
            TimeSpan elapsed = stopwatch.Elapsed;

            Console.WriteLine($"Elapsed Time (Seconds): {elapsed.TotalSeconds} s");
            Console.ReadLine();
        }

        private static void CookMealSynchronously()
        {
            Console.WriteLine("Cooking meal...");

            CutVegetablesSynchronously();
            BoilWaterSynchronously();
            CompleteOtherCookingSynchronously();
        }

        private static void CutVegetablesSynchronously()
        {
            Console.WriteLine("Chopping vegetables...");
            Task.Delay(3000).Wait(); // Simulating a synchronous task
            Console.WriteLine("Vegetables are ready!");
        }

        private static void BoilWaterSynchronously()
        {
            Console.WriteLine("Boiling water...");
            Task.Delay(3000).Wait(); // Simulating a synchronous task
            Console.WriteLine("Water is hot!");
        }      

        private static void CompleteOtherCookingSynchronously()
        {
            Console.WriteLine("Adding Seasonings...");
            Console.WriteLine("Tasting for salt...");
            Console.WriteLine("Cooking for 5 seconds");

            Task.Delay(5000).Wait();
            Console.WriteLine("Done cooking!");
        }
    }
}
