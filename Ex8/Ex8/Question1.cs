using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ex8
{
    internal class Question1
    {
        public static string para;
        public static void word_printing()
        {
            string[] li=para.Split(' ');
            for(int i = 0; i < li.Length; i++)
            {
                Console.Write(li[i]+", ");
             }
            Thread.Sleep(2000);
        }
        public static void vowels_printing()
        {
            for(int i = 0; i < para.Length; i++)
            {
                if ("aeiouAEIOU".Contains(para[i]))
                {
                    Console.Write(para[i]+", ");
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter any Paragraph");
            para=Console.ReadLine();

            Thread t1=new Thread(word_printing);
            Thread t2=new Thread(vowels_printing);
            t1.Start();
            t1.Join();
            t2.Start();
            t2.Join();

            Console.ReadKey();

        }
    }
}
