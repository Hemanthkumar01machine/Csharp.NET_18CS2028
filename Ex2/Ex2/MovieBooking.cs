using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class MovieBooking
    {
         static void Main(string[] args)
        {
            string name, tname;
            int nos, price;

            Console.WriteLine("Enter Movie Details");
            Console.Write("Name: ");
            name=Console.ReadLine();

            Console.Write("Theater Name: ");
            tname = Console.ReadLine();

            Console.Write("#. Tickets: ");
            nos = Convert.ToInt16(Console.ReadLine());

            Console.Write("Price: ");
            price = Convert.ToInt16(Console.ReadLine());

            Movie movie1 = new Movie(name,tname,nos,price);

            while (true){
                Console.Write("\n1. Display \n2. Buy Tickets \n0. Exit \nEnter Your Choice: ");
                int ch=Convert.ToInt16(Console.ReadLine());
                if (ch == 1)
                {
                    Console.WriteLine();
                    movie1.display();
                }
                else if (ch == 2)
                {
                    Console.Write("Enter #. Tickets: ");
                    int no_t=Convert.ToInt16(Console.ReadLine());
                    if (no_t <= movie1.tickets)
                    {
                        int tot_cost = no_t * movie1.Cost;
                        Console.WriteLine("Total Cost: "+tot_cost);
                        movie1.tickets = movie1.tickets-no_t;
                        
                    }
                    else { Console.WriteLine("Enter Vaild #. Tickets"); }
                }
                else if (ch == 0)
                {
                    Console.WriteLine("\nThanks for Visiting");
                    break;
                }
                else
                {
                    Console.WriteLine("Enter a vaild Input");
                }
            }

            Console.ReadKey();
        }
    }
}
