using BenchmarkDotNet.Attributes;
using System;

namespace Fibonacci
{
    [MemoryDiagnoser]
    public class FibonacciBenchmark
    {
        [Benchmark(Baseline = true)]
        public void LazyRec()
        {
            FibonacciLazy.Fib(15);
        }

        [Benchmark]
        public void MemoRecArray()
        {
            FibonacciMemoization.FibRecArray(15);
        }

        [Benchmark]
        public void MemoRecDictionary()
        {
            FibonacciMemoization.FibRecDictionary(15);
        }

        [Benchmark]
        public void MemoTaulationSumPreviousElements()
        {
            FibonacciTabulation.FibSumPreviousElements(15);
        }

        [Benchmark]
        public void MemoTaulationSumForwards()
        {
            FibonacciTabulation.FibSumForwards(15);
        }
    }       
}           
