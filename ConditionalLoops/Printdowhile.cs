using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalLoops
{
    class Printdowhile
    {
        static void Main(string[] args)
        {
            int i = 0;
            Console.WriteLine("Enter the number");
            int n = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i <= n);
        }
    }
}
