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
            Console.WriteLine(FibonacciLazy.Fib(6));
            Console.WriteLine(FibonacciLazy.Fib(7));
            Console.WriteLine(FibonacciLazy.Fib(8));
            //Console.WriteLine(FibonacciLazy.Fib(50));
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
    }
}
