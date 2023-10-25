using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7
{
    class MyCalculator
    {
        public long power(int n, int p)
        {
            if (n < 0 || p < 0) throw new Exception("System.Exception: n or p should not be negative");
            if (n == 0 && p==0) throw new Exception("System.Exception: n and p should not be zero");
            return (long) Math.Pow(n, p);
        }
    }
    internal class SetA2
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n value: ");
            int n=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter p value: ");
            int p = Convert.ToInt32(Console.ReadLine());
            MyCalculator mycal=new MyCalculator();
            try
            {
                long result=mycal.power(n, p);
                Console.WriteLine("Result: " + result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();

        }
    }
}
