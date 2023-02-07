using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    internal class Concert
    {
        string Title { get; set; }
        string Location { get; set; }
        string Date { get; set; }
        string Time { get; set; }
        public double Price { get; set; }

        // Default constructor
        public Concert()
        {
            Title = "";
            Location = "";
            Date = "";
            Time = "";
            Price = 0.0;
        }

        // Constructor with parameters
        public Concert(string title, string location, string date, string time, double price)
        {
            Title = title;
            Location = location;
            Date = date;
            Time = time;
            Price = price;
        }

        // Method to get all concert information as text
        public string GetConcertInfo()
        {
            return string.Format("Title: {0} | Location: {1} | Date: {2} | Time: {3} | Price: {4} eur", Title, Location, Date, Time, Price); 
        }

        // Operator to compare two Concert objects
        public static bool operator ==(Concert c1, Concert c2)
        {
            return c1.Equals(c2);
        }

        // Operator to compare two Concert objects
        public static bool operator !=(Concert c1, Concert c2)
        {
            return !c1.Equals(c2);
        }

        // Operator to compare if Concert objects is larger
        public static bool operator < (Concert c1, Concert c2)
        {
            return c1.Price < c2.Price;
        }

        // Operator to compare if Concert object is smaller
        public static bool operator > (Concert c1, Concert c2)
        {
            return c1.Price > c2.Price;
        }

        // Operator to increase the concert price by 5 units
        public static Concert operator ++(Concert c)
        {
            c.Price += 5;
            return c;
        }

        // Operator to decrease the concert price by 5 units
        public static Concert operator --(Concert c)
        {
            c.Price -= 5;
            return c;
        }
    }
}
