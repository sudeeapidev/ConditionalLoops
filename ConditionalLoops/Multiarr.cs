using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalLoops
{
    class Multiarr
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of array");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[x, y];
            int sum = 0;
            Console.WriteLine("Enter elements of the array");
            for (int i = 0; i < x; i++)
            {
                for(int j = 0; j < y; j++)
                {
                    arr[i,j]=Convert.ToInt32(Console.ReadLine());
                    // = sum + arr[i,j];
                    
                }
                Console.WriteLine(" ");
            }
            /*foreach (int a in arr)
            {
                Console.WriteLine(a);
            }*/
            for(int i = 0;i < x; i++)
            {
                sum = 0;
                for (int j = 0;j <y; j++)
                {
                    sum += arr[i, j];
                }

                Console.WriteLine("Sum of " + (i +1)+ " row is " + sum);
                Console.WriteLine("done");
            }
        }
    }
}
