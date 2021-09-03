using System;

namespace Fibonacci
{
    /*
     * Write a function that takes in a number as an argument.
     * The function should return the n-th number of the Fibonacci sequence.
     */

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FibRec(6));
            Console.WriteLine(FibRec(7));
            Console.WriteLine(FibRec(8));
            //Console.WriteLine(FibRec(50));
            Console.WriteLine();

            Console.WriteLine(FibonacciMemoization.FibRec(6));
            Console.WriteLine(FibonacciMemoization.FibRec(7));
            Console.WriteLine(FibonacciMemoization.FibRec(8));
            Console.WriteLine(FibonacciMemoization.FibRec(50));
            Console.WriteLine();

            Console.WriteLine(FibonacciMemoization.FibIterative(6));
            Console.WriteLine(FibonacciMemoization.FibIterative(7));
            Console.WriteLine(FibonacciMemoization.FibIterative(8));
            Console.WriteLine(FibonacciMemoization.FibIterative(50));
        }

        public static int FibRec(int n)
        {
            if (n <= 2)
            {
                return 1;
            }

            return FibRec(n - 1) + FibRec(n - 2);
        }
    }
}
