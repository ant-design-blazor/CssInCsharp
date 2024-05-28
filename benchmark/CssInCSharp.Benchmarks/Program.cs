// See https://aka.ms/new-console-template for more information
using BenchmarkDotNet.Running;
using CssInCSharp.Benchmarks;

var summary = BenchmarkRunner.Run<Benchmark>();
