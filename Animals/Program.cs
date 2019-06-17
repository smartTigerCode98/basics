
using System.Collections.Generic;

namespace Animals
{
    public class Program
    {
        public static void Main()
        {
            
            ShowInfo showInfo = new ShowInfo();
            
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
                showInfo.Show(cat);
            }

            for (int i = 0; i < cats.Count; i++)
            {
                showInfo.Show(cats[i]);
            }

            int j = 0;

            while (j < cats.Count)
            {
                showInfo.Show(cats[j]);
                j++;
            }
        }
    }
}