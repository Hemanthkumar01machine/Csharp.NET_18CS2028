using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    internal class LeapYear
    {
        static void Main(string[] args)
        {
            Console.Write("Enter any Year to check is Leap year or not: ");
            int year=Convert.ToInt32(Console.ReadLine());

            if ((year%400==0)||(year%4==0 && year%100!=0))
            {
                Console.WriteLine("\n"+year+" is a Leap Year");
            }
            else
            {
                Console.WriteLine("\n"+year+" is not a Leap Year");
            }
            Console.ReadKey();
        }
    }
}
