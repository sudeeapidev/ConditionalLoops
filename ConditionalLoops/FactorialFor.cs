namespace ConditionalLoops
{
    internal class FactorialFor
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int n = Convert.ToInt32(Console.ReadLine());
            int k=1;
            for(int i = n; i > 0; i--) 
            {
                k = k * i;
            }
            Console.WriteLine("The factorial of the number is "+k);
        }
    }
}
