using static CssInCSharp.Styles;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Jobs;

namespace CssInCSharp.Benchmarks
{
	[SimpleJob(RuntimeMoniker.Net50, baseline: true)]
	[SimpleJob(RuntimeMoniker.Net60)]
	[SimpleJob(RuntimeMoniker.Net70)]
	[SimpleJob(RuntimeMoniker.Net80)]
	[Config(typeof(Config))]
    public class Benchmark
    {
        private class Config : ManualConfig
        {
            public Config()
            {
                AddDiagnoser(MemoryDiagnoser.Default);
            }
        }

        [Benchmark]
        public string CreateCss()
        {
            return BenchmarkCss.ToString();
        }
    }
}
