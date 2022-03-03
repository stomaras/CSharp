using System;

namespace ReadKeyMethodUseCases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int c = 0;
            Console.WriteLine("The series is:");

            for(int i = 1; i < 10; i++)
            {
                c = c + i;
                Console.Write(c + "");
            }

            Console.WriteLine("\npress any key to exit the process...");

            Console.ReadKey();
        }
    }
}
