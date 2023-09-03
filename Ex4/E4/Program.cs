using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4
{
    internal class Matrix_Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4;
            Console.WriteLine("Enter Matrix M1 Elements: ");
            Console.Write("[0,0] = ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("[0,1] = ");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("[1,0] = ");
            n3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("[1,1] = ");
            n4 = Convert.ToInt32(Console.ReadLine());
            Matrix M1 = new Matrix(n1, n2, n3, n4);
            int o1, o2, o3, o4;
            Console.WriteLine("\nEnter Matrix M2 Elements: ");
            Console.Write("[0,0] = ");
            o1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("[0,1] = ");
            o2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("[1,0] = ");
            o3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("[1,1] = ");
            o4 = Convert.ToInt32(Console.ReadLine());
            Matrix M2 = new Matrix(o1,o2,o3,o4);

            Console.Write("M1 ");
            M1.Matrix_display();
            Console.Write("M2 ");
            M2.Matrix_display();

            Matrix M3 = M1 + M2;
            Console.Write("M3 Matrix(M1+M2) ");
            M3.Matrix_display();
            Matrix M4 = M1 * M2;
            Console.Write("M4 Matrix(M1*2) ");
            M4.Matrix_display();
            Console.ReadKey();
        }
    }
}
