using Assignment_II;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Here we declare an arrays for Flights objects
            Flight[] flight = new Flight[2];

            // Flight infro
            flight[0] = new Flight(1001, "Helsinki", "Oulu", "20/02/2023");
            flight[1] = new Flight(1002, "Oulu", "Helsinki", "27/02/2023");

            // Here we declare an arrays for Customer objects
            Customer[] customer = new Customer[4];

            // Customer info
            customer[0] = new Customer("Jarkko", 301, 1001);
            customer[1] = new Customer("Kerkko", 302, 1002);
            customer[2] = new Customer("Kalevi", 303, 1002);
            customer[3] = new Customer("Paula", 304, 1001);


            int input = 0;
            int id = 0;
            int id2 = 0;
            int flighID;
            int fID;
            int customerID;
            string name;
            string date;
            string origin;
            string destination;


            while (input != 5) 
            {

                Console.WriteLine("");
                Console.WriteLine("1 add customer");
                Console.WriteLine("2 add flight");
                Console.WriteLine("3 search flight");
                Console.WriteLine("4 search customer");
                Console.WriteLine("5 exit");
                Console.WriteLine("\n");
                input = Int16.Parse(Console.ReadLine());

                switch (input) { 
                
                    case 1:
                        Console.WriteLine("\n");
                        Console.WriteLine("Write customer name\n");
                        name = Console.ReadLine();
                        Console.WriteLine("\nWrite customer ID\n");
                        customerID = Int16.Parse(Console.ReadLine());
                        Console.WriteLine("\nWrite flight ID\n");
                        flighID = Int16.Parse(Console.ReadLine());
                        Array.Resize(ref customer, customer.Length + 1);
                        customer[customer.Length -1] = new Customer(name, customerID, flighID);
                        Console.WriteLine("\n");
                        Console.WriteLine("\n");
                        break;

                    case 2:
                        Console.WriteLine("\n");
                        Console.WriteLine("Write flight ID\n");
                        fID = Int16.Parse(Console.ReadLine());
                        Console.WriteLine("\nWrite flight date\n");
                        date = Console.ReadLine();
                        Console.WriteLine("\nWrite flight origin\n");
                        origin = Console.ReadLine();
                        Console.WriteLine("\nWrite flight destination\n");
                        destination = Console.ReadLine();
                        Array.Resize(ref flight, flight.Length + 1);
                        flight[flight.Length - 1] = new Flight(fID, date, origin, destination);
                        Console.WriteLine("\n");
                        Console.WriteLine("\n");
                        break;

                    case 3:
                        Console.WriteLine("\n");
                        Console.WriteLine("Write flight ID\n");
                        id = Int16.Parse(Console.ReadLine());
                        CustomerFlightHandler handler1 = new CustomerFlightHandler(customer, flight);
                        Console.Write(handler1.SearchFlight(id));
                        Console.WriteLine("\n");
                        break;

                    case 4:
                        Console.WriteLine("\n");
                        Console.WriteLine("Write customer ID\n");
                        id2 = Int16.Parse(Console.ReadLine());
                        CustomerFlightHandler handler2 = new CustomerFlightHandler(customer, flight);
                        Console.Write(handler2.SearchCustomer(id2));
                        Console.WriteLine("\n");
                        break;

                    case 5:
                        break;

                    default:
                        Console.WriteLine("1 add customer\n");
                        Console.WriteLine("2 add flight\n");
                        Console.WriteLine("3 search flight\n");
                        Console.WriteLine("4 search customer\n");
                        Console.WriteLine("5 exit\n");
                        Console.WriteLine("");
                        break;

                }
            }
            return;
        }
    }
}
