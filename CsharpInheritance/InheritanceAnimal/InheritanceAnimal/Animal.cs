using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAnimal
{
    internal class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsHungry { get; set; }

        public Animal (string name, int age){
            Name = name;
            Age = age;
            IsHungry = true;
        }

        // an empty virtual MakeSound for other classes to override
        public virtual void makeSounds()
        {
            
        }

        // a virtual method called Eat which sub classes can override
        public virtual void eat()
        {
            // check if the animal is hungry
            if (IsHungry)
            {
                Console.WriteLine($"{Name} eating now");
            }
            else
            {
                Console.WriteLine($"{Name} is not hungry now");
            }
        }

        public virtual void play()
        {
            Console.WriteLine($"{Name} is playing now");
        }

        
    }
}
