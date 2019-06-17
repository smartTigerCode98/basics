using System;

namespace Animals
{
    public class Cat
    {
        public string Name { get; set; }

        public string Colour { get; set; }
        
        public int Age { get; set; }
        

        public Cat(){}
        
        public Cat(string name, string colour, int age)
        {
            Name = name;
            Colour = colour;
            Age = age;
        }
        
    }
}