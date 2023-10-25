using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
{
    internal class Section2
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Any String: ");
            StringBuilder sb = new StringBuilder(Console.ReadLine());
            Console.WriteLine("Results of the Opearations:");
            int sbl=sb.Length;
            Console.WriteLine("1. Length: "+sbl);
            sb.Append("|APPENDED|");
            Console.WriteLine("2. Append: " + sb);
            sb.AppendLine();
            Console.WriteLine("3. AppendLine: " + sb);
            sb.AppendFormat("{0} Inserted", "|APPEND FORMAT|");
            Console.WriteLine("4. AppendFormat: " + sb);
            sb.Insert(0, sb+" ");
            Console.WriteLine("5. Insert: " + sb);
            sb.Remove(sbl,sb.Length-sbl);
            Console.WriteLine("6. Remove: " + sb);
            Console.ReadKey();

        }
    }
}
