using BenchmarkDotNet.Attributes;

namespace BestSum
{
    [MemoryDiagnoser]
    public class BestSumBenchmark
    {
        [Benchmark(Baseline = true)]
        public void LazyRec()
        {
            BestSumLazy.BestSum(35, new int[] { 1, 2, 5, 25 });
        }

        [Benchmark]
        public void MemoRecDictionary()
        {
            BestSumMemoization.BestSum(35, new int[] { 1, 2, 5, 25 });
        }
    }
}