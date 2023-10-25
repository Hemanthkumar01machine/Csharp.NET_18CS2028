using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
{
    internal class Section1
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Any string: ");
            string str=Console.ReadLine();
            while (true)
            {
                bool flag = true;
                Console.Write("\n1. Length \n2. Insert Into String \n3. Remove From String \n4. Replace String \n5. To Upper \n6. To Lower \n7. Split String \n8. Copy String \n9. Contains To \n10. Join \n11. Sub String  \n0. Exit \nEnter Your Choice: ");
                int ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 0: flag = false; break;
                    case 1: Console.WriteLine("\nLength of the String: " + str.Length); break;
                    case 2: Console.WriteLine("\nInserted String: " + str.Insert(0, "|INSERTED|")); break;
                    case 3: Console.WriteLine("\nRemoved String: " + str.Remove(str.Length / 2)); break;
                    case 4: Console.WriteLine("\nReplaced String: " + str.Replace(str[0], str[1])); break;
                    case 5: Console.WriteLine("\nUpper Case: " + str.ToUpper()); break;
                    case 6: Console.WriteLine("\nLower Case: " + str.ToLower()); break;
                    case 7: String[] li = str.Split(new char[] { 'a', 'e', 'i', 'o', 'u' }); Console.Write("\nSplited String: "); for (int i = 0; i < li.Length; i++){ Console.Write(li[i]+", "); } Console.WriteLine(); break;
                    case 8: var str1 = str.Clone();  Console.WriteLine("\nCopied String: " + str1); break;
                    case 9: Console.Write("String to Check: "); String s = Console.ReadLine(); Console.WriteLine("\nContained in: "+str.Contains(s)); break;
                    case 10: Console.WriteLine("\nJoined String: "+str+"|ALPHA STRING|"); break;
                    case 11: Console.WriteLine("\nSub String: "+str.Substring((str.Length%2)+1)); break;
                    default: Console.WriteLine("Please Enter a Valid Choice"); break;
                }

                if (!flag)
                {
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
