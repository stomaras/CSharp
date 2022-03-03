using System;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string characterName = "John";
            int characterAge = 35;

            Console.WriteLine("There once was a man named " + characterName);
            Console.WriteLine("He was " + characterAge + " years old. He really liked the name " + characterName + " But did not like being " + characterAge) ;

            Console.ReadLine();
        }
    }
}
