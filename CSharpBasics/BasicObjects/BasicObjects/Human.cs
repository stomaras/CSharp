using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicObjects
{
    internal class Human  
    {
        private String firstName;
        private String lastName;
        private int age;
        private String color;

        public Human(string firstName, string lastName, int age, string color)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.color = color;
        }

        public Human(string firstName, string lastName, string color)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.color = color;
        }

        public void IntroduceMyself()
        {
            if(age != 0)
            {
                Console.WriteLine("Hi, I am {0} {1} and {2} years old. My eye color is {3}", firstName, lastName, age, color);
            } else
            {
                Console.WriteLine("Hi, I'm {0} {1}. My eye color is {2}", firstName, lastName, color);
            }
        }

    }
}
