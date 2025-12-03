using BenchmarkDotNet.Running;

namespace CosmicLexicon.Foundation.GuardClauses.PerformanceTests;

public class Program
{
    public static void Main(string[] args)
    {
        var summary = BenchmarkRunner.Run<StringBenchmarks>();
    }
}