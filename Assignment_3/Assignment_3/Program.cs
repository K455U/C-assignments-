using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an ArrayList and add Concert objects
            ArrayList concerts = new ArrayList();
            concerts.Add(new Concert("Rockfest", "Hyvinkää", "08/06/2023", "20:00", 80.00));
            concerts.Add(new Concert("Classical Concert", "Helsinki", "01/04/2023", "19:00", 40.00));
            concerts.Add(new Concert("Pori Jazz", "Pori", "07/07/2023", "18:00", 65.50));
            concerts.Add(new Concert("Ruisrock", "Turku", "07/07/2023", "17:00", 99.99));
            concerts.Add(new Concert("Weekend festival", "Espoo", "04/08/2023", "16:00", 80.00));

            // Sort the Concert objects in ascending order based on their price
            concerts.Sort(new ConcertComparer());

            // Print out the Concert objects information
            Console.WriteLine("Concerts Information");
            Console.WriteLine("____________________");
            foreach (Concert c in concerts)
            {
                Console.WriteLine(c.GetConcertInfo());
            }

        }
    }

    // Comparer class to compare Concert objects
    public class ConcertComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            Concert c1 = (Concert)x;
            Concert c2 = (Concert)y;
            return c1.Price.CompareTo(c2.Price);
        }
    }
}
