using BenchmarkDotNet.Running;
using System;

namespace CanSum
{
    /*
     * Write a function that takes in a targetSum and an array of numbers as arguments.
     * The function should return a boolean indicating whether or not it is possible 
     * to generate the tagretSum using numbers form the array.
     * You may use an element of the array as many times as needed.
     * You may assume that all input numbers are nonnegative.
     */

    class Program
    {
        static void Main(string[] args)
        {
            var results = BenchmarkRunner.Run<CanSumBenchmark>();
        }
    }
}
