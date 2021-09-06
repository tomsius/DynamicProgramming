using BenchmarkDotNet.Running;
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
            var results = BenchmarkRunner.Run<FibonacciBenchmark>();
        }
    }
}
