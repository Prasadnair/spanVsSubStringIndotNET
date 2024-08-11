using BenchmarkDotNet.Attributes;

namespace SpanVsSubString
{
    [MemoryDiagnoser]
    public class StringManipulationBenchmark
    {
        private const string Data = "This is a sample string for demonstrating Span and Substring performance in .NET.";

        [Benchmark]
        public string UsingSubstring()
        {
            return Data.Substring(10, 6);
        }

        [Benchmark]
        public ReadOnlySpan<char> UsingSpan()
        {
            return Data.AsSpan().Slice(10, 6);
        }

        [Benchmark]
        public string SpanToString()
        {
            return Data.AsSpan().Slice(10, 6).ToString();
        }
    }
}
