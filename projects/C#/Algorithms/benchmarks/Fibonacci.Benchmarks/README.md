# Algorithims

Benchmark the performance of different algorithm's implementations.

## Setup

[Install .NET Core](https://microsoft.com/net/core)

## Build

`$ dotnet build`

## Test

Execute `dotnet test`, specifying the test project path.

`$ dotnet test tests/Fibonacci.Tests/Fibonacci.Tests.csproj`

## Benchmark

Execute `$ dotnet run -c RELEASE`, specifying the benchmark project path.
`$ dotnet run -c RELEASE --project benchmarks/Fibonacci.Benchmarks/Fibonacci.Benchmarks.csproj`

### Output example

<img src="../../resources/FibonacciBenchmark.png"/>
