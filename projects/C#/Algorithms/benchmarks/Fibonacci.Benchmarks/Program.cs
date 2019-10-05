using BenchmarkDotNet.Running;

namespace Fibonacci.Benchmarks
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<FibonacciBenchmarks>();
        }
    }
}
