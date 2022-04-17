using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter number");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 7 == 0)
            {
                Console.WriteLine("The number is devided to 7");
            }
            else if (number % 7 <= 3)
            {
                number = number - (number % 7);
                Console.WriteLine("The closest number devided to 7 is:");
                Console.WriteLine(number);
            }
            else
            {
                number = number+(7-(number % 7));
                Console.WriteLine("The closest number devided to 7 is below:");
                Console.WriteLine(number);
            }
            
        }
    }
}
