using BenchmarkDotNet.Attributes;

namespace CanSum
{
    [MemoryDiagnoser]
    public class CanSumBenchmark
    {
        [Benchmark(Baseline = true)]
        public void LazyRec()
        {
            CanSumLazy.CanSum(270, new int[] { 7, 14 });
        }

        [Benchmark]
        public void MemoRecArray()
        {
            CanSumMemoization.CanSumArray(270, new int[] { 7, 14 });
        }

        [Benchmark]
        public void MemoRecDictionary()
        {
            CanSumMemoization.CanSumDictionary(270, new int[] { 7, 14 });
        }
    }
}