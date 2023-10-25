using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ex8
{
    internal class Question2
    {
        public static int[] arr;
        public static void even_printing()
        {
            Console.WriteLine("Displaying Even Numbers:");
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i]%2 == 0)
                {
                    Console.Write(arr[i]+", ");
                }
            }
            Thread.Sleep(2000);
        }
        public static void odd_printing()
        {
            Console.WriteLine("\nDisplaying Odd Numbers:");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    Console.Write(arr[i] + ", ");
                }
            }

        }
        static void Main(string[] args)
        {
            arr=new int[10];
            Console.WriteLine("Enter Array Elements: ");
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i]=Convert.ToInt32(Console.ReadLine());
            }
            Thread t1=new Thread(even_printing);
            Thread t2=new Thread(odd_printing);

            t1.Start();
            t1.Join();
            t2.Start();
            t2.Join();

            Console.ReadKey();
        }
    }
}
