using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;
using LazyLoader;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EvaluatorTest
{
    [TestClass]
    [SimpleJob(RunStrategy.Throughput, targetCount: 100)]
    [MinColumn, MaxColumn, MeanColumn, MedianColumn]
    public class EvaluatorQueueTests
    {
        [TestMethod]
        [Benchmark]
        public void Evaluator_Queue_Should_Return_22()
        {
            // Arrange
            IEvaluator<int> evaluator = new EvaluatorQueue<int>();

            // Act
            evaluator.Add((val, additionalVals) => val / 2);
            evaluator.Add((val, additionalVals) => val + additionalVals[0], 5);
            evaluator.Add((val, additionalVals) => val + 1 + additionalVals[0], 20);
            evaluator.Add((val, additionalVals) => val - additionalVals[0] - additionalVals[1], 5, 3);

            int finalResult = evaluator.Evaluate(8);
            // Assert
            Assert.AreEqual(22, finalResult, "Final result is wrong");
        }
    }
}
