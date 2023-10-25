using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7
{
    internal class SetA1
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter Numerator: ");
                int num=Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Denominator: ");
                int den = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Result: " + num / den);
            }
            catch (FormatException)
            {
                Console.WriteLine("System.ArgumentException");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("System.DivideByZeroException: / by zero");
            }
            Console.ReadKey();
        }
    }
}
