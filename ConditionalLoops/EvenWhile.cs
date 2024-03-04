using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalLoops
{
      class EvenWhile
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of elements");
            int num = Convert.ToInt32(Console.ReadLine());
            int i=0;
            int sum = 0;
            Console.WriteLine("The even numbers are ");
            while(i <=num) 
            {
                if(i %2 == 0)
                {
                    sum += i;
                    Console.Write(i + " ");
                    
                }
                i++;
            }
            Console.WriteLine("The sum of first " + num + " even numbers is " + sum);
        }
    }
}
