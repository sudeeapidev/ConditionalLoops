using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalLoops
{
     class DuplicateArray
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the number of elements");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            int k = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter " + (i+1) + " Element");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Elements of the array are: ");
            for (int i = 0; i < n; i++)
            {
                k = 0;
                for (int j = 0; j < n; j++)
                {
                    if (arr[i] == arr[j])
                        k++;


                }
                if (k >= 2)
                {

                }
                else
                    Console.Write(arr[i] + " ");
            }
        }
    }
}
    

