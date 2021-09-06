using BenchmarkDotNet.Attributes;

namespace GridTraveler
{
    [MemoryDiagnoser]
    public class GridTravelerBenchmark
    {
        [Benchmark(Baseline = true)]
        public void Lazy15()
        {
            GridTravelerLazy.GridTraveler(15, 15);
        }

        [Benchmark]
        public void Memo15()
        {
            GridTravelerMemoization.GridTraveler(15, 15);
        }
    }
}