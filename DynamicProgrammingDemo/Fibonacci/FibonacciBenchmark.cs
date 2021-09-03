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
        public void MemoRec15()
        {
            FibonacciMemoization.FibRec(15);
        }

        [Benchmark]
        public void MemoIterative15()
        {
            FibonacciMemoization.FibIterative(15);
        }
    }       
}           
