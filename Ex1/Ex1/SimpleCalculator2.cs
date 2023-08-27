using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    internal class SimpleCalculator2
    {
        static int simple_cal2(char ch, params int[] nums)
        {
            int res = nums[0];

            switch (ch)
            {
                case '+':
                    for (int i = 1; i < nums.Length; i++)
                    {
                        res += nums[i];
                    }
                    break;
                case '-':
                    for (int i = 1; i < nums.Length; i++)
                    {
                        res -= nums[i];
                    }
                    break;
                case '*':
                    for (int i = 1; i < nums.Length; i++)
                    {
                        res *= nums[i];
                    }
                    break;
                case '/':
                    for (int i = 1; i < nums.Length; i++)
                    {
                        res /= nums[i];
                    }
                    break;
            }
            return res;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter #. Inputs: ");
            int n=Convert.ToInt32(Console.ReadLine());
            int[] nums=new int[n];

            Console.WriteLine("Enter #: ");
            for (int i = 0; i < n; i++)
            {
                nums[i]=Convert.ToInt32(Console.ReadLine());
            }
            Console.Write(" \n+ => Add \n- => Subtract \n* => Multiply \n/ => Divide \nEnter Your Choice:");
            char ch = (char)Console.Read();

            Console.WriteLine("\nResult is: " + simple_cal2(ch, nums));

            Console.ReadKey();
        }
    }
}
