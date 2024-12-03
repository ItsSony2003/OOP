using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWatchOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a Stopwatch instance
            StopWatch stopWatch = new StopWatch();

            // Generate an array of 100,000 random numbers
            int[] numbers = new int[100000];
            Random random = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1, 1000000);
            }

            // Measure the execution time of Selection Sort
            stopWatch.Start();
            SelectionSort(numbers);
            stopWatch.End();

            // Display the elapsed time
            Console.WriteLine("Time taken to sort 100,000 numbers using Selection Sort: "
                              + stopWatch.GetElapsedTime() + " milliseconds");

            Console.ReadKey();
        }

        public class StopWatch
        {
            private long startTime;
            private long endTime;

            //Constructor
            public StopWatch()
            {
                startTime = GetCurrentTime();
            }

            //Getter Setter
            public long StartTime
            {
                get { return startTime; }
                set { startTime = value; }
            }

            //Getter Setter
            public long EndTime
            { 
                get { return endTime; } 
                set { endTime = value; }
            }

            //Method to get current time in milliseconds
            public long GetCurrentTime()
            {
                return DateTimeOffset.Now.ToUnixTimeMilliseconds();
            }

            //Start Method
            public void Start() 
            {
                startTime = GetCurrentTime();
            }

            //End Method
            public void End()
            {
                endTime = GetCurrentTime();
            }

            //Get Time Method
            public long GetElapsedTime()
            { 
                return endTime - startTime;
            }
        }

        // Selection Sort Algorithm
        public static void SelectionSort(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }
                // Swap the found minimum element with the first element
                int temp = array[minIndex];
                array[minIndex] = array[i];
                array[i] = temp;
            }
        }
    }
}
