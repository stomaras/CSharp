using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    // Parent - Base class
    internal class ElectricalDevice
    {
        public bool IsOn { get; set; }

        public string Brand { get; set; }

        public ElectricalDevice(bool isOn, string brand)
        {
            IsOn = isOn;
            Brand = brand;
        }

        public void SwitchOn()
        {
            IsOn = true;
        }

        public void SwitchOff()
        {
            IsOn = false;
        }

        public void ListenDevice()
        {
            if (IsOn)
            {
                Console.WriteLine("You here the electrical device now");
            }
            else
            {
                Console.WriteLine("Your electrical device is closed !  Switch on first");
            }
        }
    }
}
