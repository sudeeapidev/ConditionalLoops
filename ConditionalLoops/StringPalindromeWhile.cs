using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalLoops
{
    class StringPalindromeWhile
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string name=Console.ReadLine();
            string rev="";
            int n = name.Length;
            while (n>0)
            {
                rev = rev + name[n-1];
                n--;
            }
            if (name.Equals(rev))
                Console.WriteLine("The entered string is Palindrome");
            else
                Console.WriteLine("The entered string is not palindrome");
        }
    }
}
