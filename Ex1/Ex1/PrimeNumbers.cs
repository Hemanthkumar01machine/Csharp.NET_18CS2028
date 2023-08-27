using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    internal class PrimeNumbers
    {
        public static bool check(int num)
        {
            for(int i = 2; i < num/2; i++)
            {
                if (num%i == 0) { return false; }
            }
            if (num!=1)
                return true;
            else
                return false;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter Starting number: ");
            int start=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Ending number: ");
            int stop = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Prime Numbers Between the Range are as follows");
            for (int i = start; i < stop; i++)
            {
                if (check(i)){ Console.Write(i+", "); }
            }
            Console.ReadKey();
        }
    }
}
