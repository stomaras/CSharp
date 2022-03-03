﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAnimal
{
    internal class Dog : Animal
    {
        // bool property to check if the dog is Happy
        public bool IsHappy { get; set; }

        // simple constructor where we pass the name and age to our base constructor
        public Dog(string name, int age) : base(name, age)
        {
            // all dogs are happy
            IsHappy = true;
        }

        // simple override of the virtual method Eat
        public override void eat()
        {
            // to call the eat method from our base class we use the keyword "base"
            base.eat();
        }

        // override of the virtual method MakeSound
        public override void makeSounds()
        {
            // since every animal will make a totally different sound
            // each animal will implement their own version of MakeSound
            Console.WriteLine("Wuuuuf");
        }

        // override the virtual method play 
        public override void play()
        {
            if (IsHappy)
            {
                base.play();
            }
        }
    }
    
}
