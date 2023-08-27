using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    internal class Shape
    {
        public double side1, side2;
        public Shape(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
        public virtual double findArea()
        {
            Console.WriteLine("Please Derive this class using any of the shapes and then call the function");
            return 0;
        }
        public virtual int findPerimeter()
        {
            Console.WriteLine("Please Derive this class using any of the shapes and then call the function");
            return 0;
        }

    }
}
