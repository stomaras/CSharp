using System;

namespace ReadKeyUseCase3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 10; i++)
            {
                Console.Write(i);
            }
            Console.WriteLine("\npress any key to exit the process...");

            Console.ReadKey(false);
        }
    }
}
