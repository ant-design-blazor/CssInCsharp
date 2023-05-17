// See https://aka.ms/new-console-template for more information
using BenchmarkDotNet.Running;
using CssInCs.Benchmarks;

var summary = BenchmarkRunner.Run<Benchmark>();
