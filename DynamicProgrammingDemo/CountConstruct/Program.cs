using BenchmarkDotNet.Running;
using System;

namespace CountConstruct
{
    /*
     * Write a function that accepts a target string and an array 
     * of strings. The function should return the number of ways 
     * that the target can be constructed by concatenating elements
     * of the word bank array. You may reuse elements of word bnk
     * as many times as needed.
     */

    class Program
    {
        static void Main(string[] args)
        {
            var results = BenchmarkRunner.Run<CountConstructBenchmark>();
        }
    }
}
