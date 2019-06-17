
using System.Collections.Generic;

namespace Animals
{
    public class Program
    {
        public static void Main()
        {
            var firstCat = new Cat();

            firstCat.Name = "Yuri";
            firstCat.Colour = "orange";
            firstCat.Age = 21;

            var cats = new List<Cat>
            {
                new Cat("Senya", "black-white", 16),
                new Cat("Petya", "white", 12),
                new Cat("Tiger", "black", 21),
                firstCat
            };

            foreach (var cat in cats)
            {
                cat.Show();
            }

            for (int i = 0; i < cats.Count; i++)
            {
                cats[i].Show();
            }

            int j = 0;

            while (j < cats.Count)
            {
                cats[j].Show();
                j++;
            }
        }
    }
}