using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadKeyMethodUseCases
{
    internal class ReadKeyUseCase2
    {
        public static void Main(String[] args)
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
