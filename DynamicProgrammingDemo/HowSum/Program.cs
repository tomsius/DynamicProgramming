﻿using BenchmarkDotNet.Running;
using System;
using System.Linq;

namespace HowSum
{
    /*
     * Write a function that takes in a targetSum and an array of numbers as arguments.
     * The function should return an array containing any combination of elements that 
     * add up to exactly the targetSum. If there is no combination that adds up to the 
     * targetSum, then return null. If there are multiple combinations possible, you 
     * may return any single one.
     */

    class Program
    {
        static void Main(string[] args)
        {
            var results = BenchmarkRunner.Run<HowSumBenchmark>();
        }
    }
}
