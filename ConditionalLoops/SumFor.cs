using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ConditionalLoops
{
    class SumFor
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num =Convert.ToInt32(Console.ReadLine());
            int sum = 0;float avg = 0;
            for (int i = 1; i <= num; i++)
            {
                Console.Write("Enter number"+i+":");
                int number=Convert.ToInt32(Console.ReadLine());
                sum += number;
            }
            avg = sum/num;
            Console.WriteLine("The sum of numbers is " + sum + " and average of numbers is " + avg);
        }
    }
}
