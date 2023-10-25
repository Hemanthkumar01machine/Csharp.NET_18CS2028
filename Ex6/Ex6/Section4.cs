using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
{
    internal class Section4
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Any Line: ");
            String str=Console.ReadLine();
            int alphabets_count=0,vowels_count=0,consonents_count=0,digits_count=0,whitespace_count=0,special_count=0;
            for(int i=0; i<str.Length; i++)
            {
                char c=str[i];
                if (char.IsDigit(c)) { digits_count++; }
                else if (char.IsLetter(c)){ alphabets_count++; if ("aeiouAEIOU".Contains(c)) { vowels_count++; } else { consonents_count++; } }
                else if(c==' '){ whitespace_count++; }
                else{ special_count++; }

            }
            Console.WriteLine("#. Alphabets: "+alphabets_count);
            Console.WriteLine("#. Digits: " + digits_count);
            Console.WriteLine("#. Consonents: " + consonents_count);
            Console.WriteLine("#. Vowels: " + vowels_count);
            Console.WriteLine("#. Whitespace: " + whitespace_count);
            Console.WriteLine("#. Special Character: " + special_count);
            Console.ReadKey();
        }
    }
}
