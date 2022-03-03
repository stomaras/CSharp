using System;

namespace InheritanceDemo
{
    internal class Program : Object
    {
        static void Main(string[] args)
        {
            Radio myRadio = new Radio(false, "Sony");
            myRadio.SwitchOn();
            myRadio.ListenRadio();

            TV myTV = new TV(false, "Samsung");
            // method of child class
            myTV.WatchTV();
            // method of base class inherited directly into the child
            myTV.SwitchOn();
            myTV.WatchTV();
        }
    }
}
