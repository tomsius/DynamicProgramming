using BenchmarkDotNet.Attributes;

namespace HowSum
{
    [MemoryDiagnoser]
    public class HowSumBenchmark
    {
        [Benchmark(Baseline = true)]
        public void LazyRec()
        {
            HowSumLazy.HowSum(270, new int[] { 7, 14 });
        }

        [Benchmark]
        public void MemoRecDictionary()
        {
            HowSumMemoization.HowSum(270, new int[] { 7, 14 });
        }
    }
}