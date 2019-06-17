using System;

namespace Animals
{
    public class Cat
    {
        private string name { get; set; }

        private string colour { get; set; }
        
        private int age { get; set; }

        public string Name
        {
            set => name = value;
        }

        public string Colour
        {
            set => colour = value;
        }

        public int Age
        {
            set => age = value;
        }

        public Cat(){}
        
        public Cat(string name, string colour, int age)
        {
            this.name = name;
            this.colour = colour;
            this.age = age;
        }

        public void Show()
        {
            Console.WriteLine($"My name is {name}");
            Console.WriteLine($"My colour is {colour}");
            Console.WriteLine($"I'm {age} years old");
        }
    }
}