using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4
{
    internal class Rectangle_Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the Dimensions for R1");
            Console.Write("Length: ");
            int r1_l=Convert.ToInt32(Console.ReadLine());
            Console.Write("Breadth: ");
            int r1_b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Rectangle R1 = new Rectangle(r1_l, r1_b);

            Console.WriteLine("Enter the Dimensions for R2");
            Console.Write("Length: ");
            int r2_l = Convert.ToInt32(Console.ReadLine());
            Console.Write("Breadth: ");
            int r2_b = Convert.ToInt32(Console.ReadLine());
            Rectangle R2 = new Rectangle(r2_l, r2_b);

            Console.WriteLine();
            Console.WriteLine("R1 Dimensions");
            R1.display();

            Console.WriteLine("\nR2 Dimensions");
            R2.display();

            Rectangle R3 = R1 + R2;
            Console.WriteLine("\nR3 (R1+R2) Dimensions");
            R3.display();

            Console.WriteLine("\nDisplaying Results");
            Console.Write("R1==R2: ");Console.WriteLine(R1==R2);
            Console.Write("R1<R2: "); Console.WriteLine(R1 < R2);
            Console.Write("R1>=R2: "); Console.WriteLine(R1 >= R2);

            Console.ReadKey();
        }
    }
}
