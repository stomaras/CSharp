using System;

namespace PropertiesPart1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box();
            box.SetLength(2);
            box.SetHeight(4);
            box.setWidth(3);
            box.Height = 4; 
            box.DisplayInfo();

            Console.WriteLine("Front surface of the box is {0}", box.GetFrontSurface());
            Console.WriteLine("Hello World!" + box.GetLength());
        }
    }
}
