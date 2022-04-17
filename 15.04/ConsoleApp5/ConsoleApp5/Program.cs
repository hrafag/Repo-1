using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int number=0;
            Console.WriteLine("Pleasse enter any number");
            number = Convert.ToInt32(Console.ReadLine());
            if (number <= 50) 
            {
                int i = 1;
                for (i = 1; i <= number; i++)
                {
                    if (i % 3 == 0)
                    {
                        Console.WriteLine(i);
                    }
                                                       
                }
            }
            else if (number > 50 && number < 100)
                {
                int i = 51;
                for (i = 51; i < number; i++)
                {
                    if (i % 5 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
             }
            else
            {
                int i = 100;
                for (i = 100; i < number; i++)
                {
                    if (i % 8 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
           
        }
    }
}
