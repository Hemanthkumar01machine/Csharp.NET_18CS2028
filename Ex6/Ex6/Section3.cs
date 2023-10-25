using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ex6
{
    internal class Section3
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Any String: ");
            String str = Console.ReadLine();

            Regex title_regex = new Regex("\\B[A-Z]+\\B");
            Regex lower_regex = new Regex("\\B[a-z]+\\B");
            Regex digits_regex = new Regex("[0-9]");
            Regex email_regex = new Regex(@"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$");


            Console.Write("Is Title Case: ");
            if (title_regex.IsMatch(str)) { Console.WriteLine(str); }else { Console.WriteLine(false); }
            Console.Write("Is Lower Case: ");
            if (lower_regex.IsMatch(str)) { Console.WriteLine(str); } else { Console.WriteLine(false); }
            Console.Write("Has Digits: ");
            if(digits_regex.IsMatch(str)) { Console.WriteLine(true); } else { Console.WriteLine(false); }
            Console.Write("Email Validation: ");
            if(email_regex.IsMatch(str)) { Console.WriteLine("Passed"); } else { Console.WriteLine("Failed"); }
            Console.ReadKey();
        }
    }
}
