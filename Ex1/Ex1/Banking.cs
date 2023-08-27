using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    internal class Banking
    {
        static void create(int amt, out int bal)
        {
            bal = amt;
        }

        static void withdraw_amt(int amt, ref int bal)
        {
            bal-=amt;
        }
        static void Main(string[] args)
        {
            int bal;
            Console.Write("Enter Amount to create Account: ");
            int amt=Convert.ToInt32(Console.ReadLine());
            create(amt, out bal);
            Console.WriteLine("\nAccount Created Successfully");

            Console.Write("\nEnter Amount to withdraw from Account: ");
            int withdraw= Convert.ToInt32(Console.ReadLine());

            if (withdraw <= bal)
            {
                withdraw_amt(withdraw, ref bal);
                Console.WriteLine("\nAmount Withdrawn Successfully");
                Console.WriteLine("Balance: " + bal);
            }
            else
            {
                Console.WriteLine("\nWithdrawl is not possible");
            }

            Console.ReadKey();
        }
    }
}
