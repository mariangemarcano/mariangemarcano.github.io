using BenchmarkDotNet.Running;

namespace Sort.Benchmarks
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<SortBenchmarks>();
        }
    }
}
