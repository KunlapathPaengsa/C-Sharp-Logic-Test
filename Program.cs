using System;
namespace alpha
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, n;
            Console.Write("Enter number : ");
            n = int.Parse(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                if(j==i||j==n-1-i)
                        Console.Write("*");
                    else 
                        Console.Write(" ");}
                Console.WriteLine();
            }
        }
    }
}