// See https://aka.ms/new-console-template for more information
using BenchmarkDotNet.Running;
using SpanVsSubString;

Console.WriteLine("Substring Vs Span!");

var summary = BenchmarkRunner.Run<StringManipulationBenchmark>();
