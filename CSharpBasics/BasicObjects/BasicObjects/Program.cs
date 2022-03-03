using System;

namespace BasicObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human h = new Human("Spyros", "Tomaras", 23, "white");
            h.IntroduceMyself();

            Human c = new Human("Chris", "Fragulis", "Black");
            c.IntroduceMyself();
        }
    }
}
