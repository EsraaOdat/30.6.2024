using System;
using System.Xml.Linq;

namespace _30._06._2024
{
    internal class Program
    {
        public static (double sum, double average) CalculateSumAndAverage()
        {
            double sum = 0;
            int[] numbers = new int[10];

            // Loop to get 10 numbers from the user
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Number-{i + 1} : ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
                sum += numbers[i];
            }

            double average = sum / 10;
            return (sum, average);
        }




        public static double ww(double x)
        {
            return x * x * x;
        }



        static void Main(string[] args)
        {

            var result = CalculateSumAndAverage();
            Console.WriteLine($"The sum of 10 numbers is : {result.sum}");
            Console.WriteLine($"The average is : {result.average:F6}");
        }
    }
}
