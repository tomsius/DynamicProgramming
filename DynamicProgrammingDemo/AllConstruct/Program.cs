using BenchmarkDotNet.Running;
using System;
using System.Collections.Generic;

namespace AllConstruct
{
    /*
     * Write a function that accepts a target string and an array 
     * of strings. The function should return a 2D array containing
     * all of the ways that the target can be constructed by concatenating
     * elements of the word bank array. Each element of the 2D array should 
     * represent one combination that constructs the target. You may reuse
     * elements of word bank as many times as needed.
     */
    class Program
    {
        static void Main(string[] args)
        {
            var results = BenchmarkRunner.Run<AllConstructBenchmark>();
        }
    }
}
