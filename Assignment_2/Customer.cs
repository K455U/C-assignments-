using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Customer
    {
        string name;
        int id;
        int flightID;

        public Customer(string name, int id, int flightID)
        {
            this.name = name;

            this.id = id;   

            this.flightID = flightID;   
        }

        public int ID()
        {
            return this.id;
        }
        public int FlightID()
        {
            return this.flightID;
        }
        public bool SearchID(int id)
        {
            return (this.id == id);
        }
        public override string ToString()
        {
            return name + " " + id + " " + flightID;
        }
    }
}
