using System;

namespace ReadKeyMethodUseCase2
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

            Console.Write("\nPress 'Enter' to exit the process...");

            while(Console.ReadKey().Key != ConsoleKey.Enter)
            {

            }
        }
    }
}
