using BenchmarkDotNet.Attributes;
using System;

namespace Fibonacci
{
    [MemoryDiagnoser]
    public class FibonacciBenchmark
    {
        [Benchmark(Baseline = true)]
        public void LazyRec15()
        {
            FibonacciLazy.Fib(15);
        }

        [Benchmark]
        public void MemoRecArray15()
        {
            FibonacciMemoization.FibRecArray(15);
        }

        [Benchmark]
        public void MemoRecDictionary15()
        {
            FibonacciMemoization.FibRecDictionary(15);
        }

        [Benchmark]
        public void MemoIterative15()
        {
            FibonacciMemoization.FibIterative(15);
        }
    }       
}           
