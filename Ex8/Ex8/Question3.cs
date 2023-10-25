using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ex8
{
    internal class Question3
    {
        public static int num1, num2,num3;
        public void table_printing()
        {
            lock (this)
            {
                Console.WriteLine("\nPrinting Table:");
                for (int i = 1; i <= 10; i++)
                {
                    if (Thread.CurrentThread.Name == "num1_t") { Console.WriteLine(num1 + "x" + i + "=" + num1 * i); }
                    if (Thread.CurrentThread.Name == "num2_t") { Console.WriteLine(num2 + "x" + i + "=" + num2 * i); }
                    if (Thread.CurrentThread.Name == "num3_t") { Console.WriteLine(num3 + "x" + i + "=" + num3 * i); }
                }
                Thread.Sleep(2000);
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter Num1: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Num2: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Num3: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            Question3 c=new Question3();
            Thread num1_t=new Thread(c.table_printing);
            Thread num2_t = new Thread(c.table_printing);
            Thread num3_t = new Thread(c.table_printing);

            num1_t.Name = "num1_t";
            num2_t.Name = "num2_t";
            num3_t.Name = "num3_t";

            num1_t.Start();
            num2_t.Start();
            num3_t.Start();

            Console.ReadKey();
        }
    }
}
