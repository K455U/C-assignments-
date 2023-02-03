using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Flight
    {
        int id;
        string date;
        string origin, destination;

        public Flight(int id, string origin, string destination, string date)
        {
            this.id = id;   

            this.origin = origin;   

            this.destination = destination; 
            
            this.date = date;
        }

        public int ID()
        {
            return this.id;
        }
        public bool SearchID(int id)
        {
            return (this.id == id);
        }
        public override string ToString()
        {
            return id + " " + date + " " + origin + " " + destination;
        }
    }
}