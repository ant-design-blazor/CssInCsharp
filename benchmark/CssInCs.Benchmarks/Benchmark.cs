using static CssInCs.Styles;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnosers;

namespace CssInCs.Benchmarks
{
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
