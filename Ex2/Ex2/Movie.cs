using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    public class Movie
    {
        private string name, theaterName;
        private int noOfAvailableTickets, cost;

        public Movie(string name, string theaterName, int no, int cost)
        {
            this.name = name;
            this.theaterName = theaterName;
            this.noOfAvailableTickets = no;
            this.cost = cost;
        }
        public int tickets
        {
            get { return this.noOfAvailableTickets; }
            set { this.noOfAvailableTickets = value; }
        }

        public int Cost
        {
            get { return this.cost; }
            set { this.cost = value; }
        }

        public void display()
        {
            Console.WriteLine("Name: " + this.name);
            Console.WriteLine("Theater Name: " + this.theaterName);
            Console.WriteLine("Available Tickets: " + this.noOfAvailableTickets);
            Console.WriteLine("Cost: " + this.cost);
        }
    }
}
