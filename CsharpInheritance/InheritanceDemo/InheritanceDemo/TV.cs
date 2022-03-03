using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    // child class
    internal class TV : ElectricalDevice
    {
        
        public TV(bool isOn, string brand) : base(isOn, brand)
        {

        }
        
        // method to listen the Tv
        public void WatchTV()
        {
            // first check if the TV is on
            if (IsOn)
            {
                // watch the TV
                Console.WriteLine("Now watching TV!");
            }
            else
            {
                Console.WriteLine("TV is switched off, switch it on first"); 
            }
        }
    }
}
