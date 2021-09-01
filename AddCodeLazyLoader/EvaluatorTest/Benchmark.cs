using BenchmarkDotNet.Running;

namespace EvaluatorTest
{
    static class Benchmark
    {
        static void Main(string[] args)
        {
            var switcher = new BenchmarkSwitcher(new[] {
                        typeof(EvaluatorQueueTests),
                        typeof(EvaluatorToupleTests)
            });
            switcher.Run(args);
        }
    }
}
