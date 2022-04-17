using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {18,25,26,30, 22, 20};
            int largestNumber = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Yas"+numbers[i]);
                if (largestNumber < numbers[i])
                {
                    largestNumber = numbers[i];
                }
            }
            Console.WriteLine(largestNumber);
        }
    }
}
