using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace Benchmarks
{
    [RankColumn]
    [MemoryDiagnoser]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    public class AbstractFactoryBenchmarks
    {
        [Benchmark]
        public void RunGameStraightCode()
        {
            new TryOut.AbstractFactory.StraightCode.Game();
        }

        [Benchmark]
        public void RunGameRefactoredCode()
        {
            new TryOut.AbstractFactory.RefactoredCode.Game();
        }
    }
}
