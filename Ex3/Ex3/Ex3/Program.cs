using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape sh = null;
            double s1, s2;
            while (true)
            {
                Console.Write("1. Triangle \n2. Rectangle \n3. Exit \nEnter Your Choice: ");
                int ch = Convert.ToInt32(Console.ReadLine());
                if (ch == 3) break;
                else if (ch == 1)
                {
                    Console.Write("Enter Base: ");
                    s1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Height: ");
                    s2 = Convert.ToInt32(Console.ReadLine());
                    sh = new Triangle(s1, s2);
                    Console.WriteLine("Area: " + sh.findArea() + "\nPerimeter: " + sh.findPerimeter() + "\n");
                }
                else if (ch == 2)
                {
                    Console.Write("Enter Length: ");
                    s1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Breadth: ");
                    s2 = Convert.ToInt32(Console.ReadLine());
                    sh = new Rectangle(s1, s2);
                    Console.WriteLine("Area: " + sh.findArea() + "\nPerimeter: " + sh.findPerimeter() + "\n");
                }
                else Console.WriteLine("Enter a Valid Option\n");
            }
            Console.ReadKey();
        }
    }
}
