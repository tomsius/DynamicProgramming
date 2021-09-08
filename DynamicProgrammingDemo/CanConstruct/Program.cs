using BenchmarkDotNet.Running;
using System;

namespace CanConstruct
{
    /*
     * Write a function that accepts a target string and an array 
     * of strings. The function should return a boolean indicating 
     * whether or not the target can be constructed by concatenating 
     * elements of the word bank array. You may reuse elements of word 
     * bank as many times as needed.
     */

    class Program
    {
        static void Main(string[] args)
        {
            var results = BenchmarkRunner.Run<CanConstructBenchmark>();
        }
    }
}
