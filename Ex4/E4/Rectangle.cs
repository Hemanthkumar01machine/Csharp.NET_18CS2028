using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4
{
    internal class Rectangle
    {
        int l, b;
        public Rectangle(int length, int breadth)
        {
            this.l = length;
            this.b = breadth;
        }

        public void display()
        {
            Console.WriteLine("Length= " + this.l + "  Breadth= " + this.b);
        }
        public static Rectangle operator +(Rectangle first, Rectangle second)
        {
            return new Rectangle(first.l + second.l,second.b+ second.b);
        }
        public static Boolean operator ==(Rectangle first, Rectangle second)
        {
            if (first.l == second.l && first.b == second.b) return true;
            else return false;
        }
        public static Boolean operator !=(Rectangle first, Rectangle second)
        {
            if (first.l != second.l && first.b != second.b) return true;
            else return false;
        }

        public static Boolean operator >(Rectangle first, Rectangle second)
        {
            if (first.l > second.l && first.b > second.b) return true;
            else return false;
        }

        public static Boolean operator <(Rectangle first, Rectangle second)
        {
            if (first.l < second.l && first.b < second.b) return true;
            else return false;
        }

        public static Boolean operator >=(Rectangle first, Rectangle second)
        {
            if (first.l >= second.l && first.b >= second.b) return true;
            else return false;
        }

        public static Boolean operator <=(Rectangle first, Rectangle second)
        {
            if (first.l <= second.l && first.b <= second.b) return true;
            else return false;
        }
    }
}
