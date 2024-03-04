using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalLoops
{
    class MaxMinArr
    {
        int max = 0;
        int min = 0;
        public int getMax(int[] a)
        {
            foreach (int w in a)
            {
                if (w > max)
                {
                    max = w;
                }
            }
            return max;
        }
        public int getMin(int[] a) 
        {
            foreach (int w in a)
            {
                if (w < max)
                {
                    min= w;
                }
            }
            return min;
        }
        static void Main(string[] args)
        {
            MaxMinArr a1 = new MaxMinArr();
            Console.WriteLine("Enter size of array");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            
            Console.WriteLine("Enter elements of the array");
            for(int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("The maximum element is " + a1.getMax(arr));
            Console.WriteLine("The minimum element is " + a1.getMin(arr));
        }
    }
}
