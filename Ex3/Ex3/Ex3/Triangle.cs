using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    internal class Triangle:Shape
    {
        public Triangle(double side1,double side2) : base(side1, side2)
        {
            
        }
        public override double findArea()
        {
            return 0.5 * base.side1 * base.side2;
        }
        public override int findPerimeter()
        {
            return (int) base.side1 + (int)base.side2 + (int) base.side1;
        }
    }
}
