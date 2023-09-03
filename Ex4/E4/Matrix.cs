using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace E4
{
    internal class Matrix
    {
        public int[ , ] mat=new int[2,2];
        public Matrix(int a, int b, int c, int d) {
            this.mat[0, 0] = a;
            this.mat[0, 1] = b;
            this.mat[1, 0] = c;
            this.mat[1, 1] = d;
        }
        public void Matrix_display()
        {
            Console.WriteLine("Displaying Matrix");
            Console.WriteLine(this.mat[0, 0] + " "+this.mat[0, 1]);
            Console.WriteLine(this.mat[1, 0] + " " + this.mat[1, 1]);
        }
        public static Matrix operator +(Matrix A, Matrix B)
        {
            Matrix C=new Matrix(A.mat[0, 0] + B.mat[0,0], A.mat[0, 1] + B.mat[0, 1], A.mat[1, 0] + B.mat[1, 0], A.mat[1,1] + B.mat[1,1]);
            return C;
        }
        public static Matrix operator *(Matrix A, Matrix B)
        {
            Matrix C = new Matrix(A.mat[0, 0] * B.mat[0, 0] + A.mat[0, 1] * B.mat[1,0], A.mat[0, 0] * B.mat[0, 1] + A.mat[0, 1] * B.mat[1,1], A.mat[1, 0] * B.mat[0, 0] + A.mat[1, 1] * B.mat[1, 0], A.mat[1, 0] * B.mat[0, 1] + A.mat[1, 1] * B.mat[1,1]);
            return C;
        }
    }
}
