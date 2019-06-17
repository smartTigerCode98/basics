
using System;

namespace Animals
{
    public class ShowInfo : IShow
    {
        public void Show(Cat cat)
        {
            Console.WriteLine($"My name is {cat.Name}");
            Console.WriteLine($"My colour is {cat.Colour}");
            Console.WriteLine($"I'm {cat.Age} years old");
        }
    }
}