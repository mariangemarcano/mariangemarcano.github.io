using BenchmarkDotNet.Attributes;
using Fibonacci;

[MemoryDiagnoser, MonoJob, CoreJob]
public class FibonacciBenchmarks 
{
    [Benchmark]
    public double CalculateRecursive30() => new FibonacciRecursive().Calculate(30);

    [Benchmark]
    public double CalculateIterative30() => new FibonacciIterative().Calculate(30);

    [Benchmark]
    public double CalculateSequenceIterative30() => new FibonacciSequenceIterative().Calculate(30);

    [Benchmark]
    public double CalculateRecursiveMemoization30() => new FibonacciRecursiveMemoization().Calculate(30);

    [Benchmark]
    public double CalculateIterative1000() => new FibonacciIterative().Calculate(1000);

    [Benchmark]
    public double CalculateSequenceIterative1000() => new FibonacciSequenceIterative().Calculate(1000);

    [Benchmark]
    public double CalculateRecursiveMemoization1000() => new FibonacciRecursiveMemoization().Calculate(1000);

}