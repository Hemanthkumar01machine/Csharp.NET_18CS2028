using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    internal class Matrix
    {
        int[,] matrix=new int[2,2];

        public Matrix(int a, int b, int c, int d)
        {
            this.matrix[0, 0] = a;
            this.matrix[0, 1] = b;
            this.matrix[1, 0] = c;
            this.matrix[1, 1] = d;
        }
        public void Matrix_display()
        {
            Console.WriteLine("Displaying Matrix");
            Console.WriteLine(this.matrix[0, 0] + " " + this.matrix[0, 1]);
            Console.WriteLine(this.matrix[1, 0] + " " + this.matrix[1, 1]);
        }
        public void addition(Matrix A, Matrix B)
        {
            Matrix C = new Matrix(A.matrix[0, 0] + B.matrix[0, 0], A.matrix[0, 1] + B.matrix[0, 1], A.matrix[1, 0] + B.matrix[1, 0], A.matrix[1, 1] + B.matrix[1, 1]);
            Console.WriteLine("Addition");
            C.Matrix_display();
        }
        public void subtracion(Matrix A, Matrix B)
        {
            Matrix C = new Matrix(A.matrix[0, 0] - B.matrix[0, 0], A.matrix[0, 1] - B.matrix[0, 1], A.matrix[1, 0] - B.matrix[1, 0], A.matrix[1, 1] - B.matrix[1, 1]);
            Console.WriteLine("Subtraction");
            C.Matrix_display();
        }
        public void multiplication(Matrix A, Matrix B)
        {
            Matrix C = new Matrix(A.matrix[0, 0] * B.matrix[0, 0] + A.matrix[0, 1] * B.matrix[1, 0], A.matrix[0, 0] * B.matrix[0, 1] + A.matrix[0, 1] * B.matrix[1, 1], A.matrix[1, 0] * B.matrix[0, 0] + A.matrix[1, 1] * B.matrix[1, 0], A.matrix[1, 0] * B.matrix[0, 1] + A.matrix[1, 1] * B.matrix[1, 1]);
            Console.WriteLine("Multiplication");
            C.Matrix_display();
        }
        public void division(Matrix A, Matrix B)
        {
            Matrix C = new Matrix(A.matrix[0, 0] / B.matrix[0, 0], A.matrix[0, 1] / B.matrix[0, 1], A.matrix[1, 0] / B.matrix[1, 0], A.matrix[1, 1] / B.matrix[1, 1]);
            Console.WriteLine("Division");
            C.Matrix_display();
        }

        public delegate void Matrix_delegate(Matrix A ,Matrix B);
        static void Main(string[] args)
        {
            var cone_volume_expression = (int radius, int height) => ((1 / 2) * (22 / 7) * (float)Math.Pow(radius, 2) * height);
            Console.WriteLine("Enter Dimensions of the Cone");
            Console.Write("Radius: ");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.Write("Height: ");
            int h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Volume of the Cone = "+cone_volume_expression(r,h));

            var palindrome_expression = (int num) =>
            {
                int copy = num;
                int reversed = 0;
                while (copy > 0)
                {
                    reversed *= 10;
                    int remain = copy % 10;
                    reversed += remain;
                    copy /= 10;
                }
                if (num == reversed) { return true; }
                else { return false; }
            };
            Console.Write("\n\nEnter Any Number for Palindrome Checking: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Palindrome status is " + palindrome_expression(n));

            int n1, n2, n3, n4;
            Console.WriteLine("\n\nEnter Matrix M1 Elements: ");
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

            Matrix_delegate delegate_obj=new Matrix_delegate(M1.addition);
            delegate_obj+=M1.subtracion;
            delegate_obj+=M1.multiplication;
            delegate_obj+=M1.division;
            delegate_obj(M1,M2);
            Console.ReadKey();
        }
    }
}
