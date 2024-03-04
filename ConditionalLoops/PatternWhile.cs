using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalLoops
{
    class PatternWhile
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int n = Convert.ToInt32(Console.ReadLine());
            int i = 1; int j = 1;
            while( i<=n)
            {
                j = 1;
                while ( j<=i) 
                {
                    Console.Write(i+ " ");
                    j++;
                }
                Console.WriteLine(" ");
                i++;
                
            }
        }
    }
}
