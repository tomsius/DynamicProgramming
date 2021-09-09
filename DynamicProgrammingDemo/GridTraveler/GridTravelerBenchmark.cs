using BenchmarkDotNet.Attributes;

namespace GridTraveler
{
    [MemoryDiagnoser]
    public class GridTravelerBenchmark
    {
        [Benchmark(Baseline = true)]
        public void Lazy()
        {
            GridTravelerLazy.GridTraveler(15, 15);
        }

        [Benchmark]
        public void Memo()
        {
            GridTravelerMemoization.GridTraveler(15, 15);
        }

        [Benchmark]
        public void Tabulation()
        {
            GridTravelerTabulation.GridTraveler(15, 15);
        }
    }
}