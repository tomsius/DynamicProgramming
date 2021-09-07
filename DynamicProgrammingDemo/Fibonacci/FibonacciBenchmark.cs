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
        public void MemoIterative()
        {
            FibonacciMemoization.FibIterative(15);
        }
    }       
}           
