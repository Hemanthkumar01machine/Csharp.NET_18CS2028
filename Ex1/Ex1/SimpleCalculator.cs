using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    internal class SimpleCalculator
    {
        static int simple_cal(int num1, int num2, char ch)
        {
            int res=0;

            switch (ch)
            {
                case '+':
                    res=num1 + num2;
                    break;
                case '-':
                    res=num1 - num2;
                    break;
                case '*':
                    res=num1 * num2;
                    break;
                case '/':
                    res=num1 / num2;
                    break;
            }
            return res;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter Num1: ");
            int num1=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Num2: ");
            int num2=Convert.ToInt32(Console.ReadLine());

            Console.Write(" \n+ => Add \n- => Subtract \n* => Multiply \n/ => Divide \nEnter Your Choice:");
            char ch=(char) Console.Read();

            Console.WriteLine("\nResult is: " +simple_cal(num1,num2,ch));

            Console.ReadKey();
        }
    }
}
