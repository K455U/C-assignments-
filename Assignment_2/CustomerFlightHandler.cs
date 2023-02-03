using Assignment_2;
using System.Text;
namespace Assignment_II
{
    class CustomerFlightHandler
    {
        Customer[] customers;
        Flight[] flights;
        public CustomerFlightHandler(Customer[] customers, Flight[] flights)
        {
            this.customers = customers;
            this.flights = flights;
        }
        public string SearchCustomer(int id)
        {
            StringBuilder result = new StringBuilder();
            foreach (Customer customer in this.customers)
            {
                if (customer.ID() == id)
                {
                    result.AppendLine(customer.ToString());
                    foreach (Flight flight in flights)
                    {
                        if (customer.FlightID() == flight.ID())
                        {
                            result.AppendLine(flight.ToString());
                        }
                    }
                }
            }
            if (result.ToString() != "")
            {
                return result.ToString();
            }
            else
            {
                return "no customer found with given ID\n";
            }
        }

        public string SearchFlight(int id) 
        { 

                StringBuilder result = new StringBuilder();
                foreach (Flight flight in this.flights)
                {
                    if (flight.ID() == id)
                    {
                        result.AppendLine(flight.ToString());
                        foreach (Customer customer in customers)
                        {
                            if (customer.FlightID() == flight.ID())
                            {
                                result.AppendLine(customer.ToString());
                            }
                        }
                    }
                }

                if (result.ToString() != "")
                {
                    return result.ToString();
                }
                else
                {
                    return "no flight found with given ID\n";
                }
        }
    }
}