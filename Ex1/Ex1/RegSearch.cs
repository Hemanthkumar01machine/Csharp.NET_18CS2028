using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    internal class RegSearch
    {
        static void Main(string[] args)
        {
            Console.Write("Enter #. Register #: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] reg_arr = new int[n];

            Console.WriteLine("Enter Register #s: ");
            for (int i = 0; i < n; i++)
            {
                reg_arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("\n1. Display \n2. Search \nEnter your Choice: ");
            int ch = Convert.ToInt32(Console.ReadLine());

            if (ch == 1)
            {
                Console.WriteLine("Displaying Register #s");
                for(int i = 0; i < n-1; i++)
                {
                    Console.Write(reg_arr[i] + ", ");
                }
                Console.Write(reg_arr[n-1] + ", ");
            }
            else if (ch == 2)
            {
                Console.Write("Enter Register # to search: ");
                int num=Convert.ToInt32(Console.ReadLine());
                bool flag = false;
                for (int i = 0; i < n; i++)
                {
                    if (reg_arr[i] == num)
                    {
                        Console.WriteLine(num+" is there in Register #");
                        flag = true;
                        break;
                    }
                }
                if (!flag) Console.WriteLine(num + " is not there in Register #");
            }
            Console.ReadKey();
        }
    }
}
