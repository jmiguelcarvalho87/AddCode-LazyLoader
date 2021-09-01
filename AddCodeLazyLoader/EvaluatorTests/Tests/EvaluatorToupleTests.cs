using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;
using LazyLoader;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace EvaluatorTests
{
    [TestClass]
    [SimpleJob(RunStrategy.Throughput, targetCount: 100)]
    [MinColumn, MaxColumn, MeanColumn, MedianColumn]
    public class EvaluatorToupleTests
    {
        [TestMethod]
        [Benchmark]
        public void Evaluator_Touple_For_Int_Should_Return_22()
        {
            // Arrange
            int expected = 22;
            int seed = 8;
            int addArg1 = 5;
            int addArg2 = 20;
            int addArg3 = 5;
            int addArg4 = 3;

            EvaluatorTouple<int> evaluator = new EvaluatorTouple<int>();

            // Act
            evaluator.Add((val, additionalVals) => val / 2);
            evaluator.Add((val, additionalVals) => val + additionalVals[0], addArg1);
            evaluator.Add((val, additionalVals) => val + 1 + additionalVals[0], addArg2);
            evaluator.Add((val, additionalVals) => val - additionalVals[0] - additionalVals[1], addArg3, addArg4);

            int finalResult = evaluator.Evaluate(seed);

            // Assert
            Assert.AreEqual(expected, finalResult, "Final result is wrong");
        }

        [TestMethod]
        [Benchmark]
        public void Evaluator_Touple_Should_Return_AddCode_Challenge_Is_Working_Nicely()
        {
            // Arrange
            string seed = "AddCode";
            string stringParam1 = " challenge ";
            string stringParam2 = "is ";
            string stringParam3 = "working ";
            string stringParam4 = "nicely";

            EvaluatorTouple<string> evaluator = new EvaluatorTouple<string>();

            // Act
            evaluator.Add((val, additionalVals) => val + stringParam1);
            evaluator.Add((val, additionalVals) => val + additionalVals[0], stringParam2);
            evaluator.Add((val, additionalVals) => val + stringParam3 + additionalVals[0], stringParam4);

            string finalResult = evaluator.Evaluate(seed);
            // Assert
            Assert.AreEqual("AddCode challenge is working nicely", finalResult, "Final result is wrong");
        }

        [TestMethod]
        [Benchmark]
        public void Evaluator_Touple_With_No_Function_Returns_Seed()
        {
            // Arrange
            int seed = 2;
            int expected = seed;
            var evaluator = new EvaluatorTouple<int>();

            //Act
            int result = evaluator.Evaluate(seed);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [Benchmark]
        public void Evaluator_Touple_For_Double_With_Seed_5_And_Function_Power_Of_2_With_No_Additional_Arg_Aeturns_25()
        {
            // Arrange
            int seed = 5;
            int expected = 25;
            var evaluator = new EvaluatorTouple<double>();

            // Act
            evaluator.Add((val, additionalVals) => Math.Pow(val, 2));
            double result = evaluator.Evaluate(seed);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [Benchmark]
        public void Evaluator_Touple_For_Boolean_With_Seed_TRUE_And_Additional_Args_TRUE_And_False_Should_Return_FALSE()
        {
            // Arrange
            bool seed = true;
            bool expected = false;
            var evaluator = new EvaluatorTouple<bool>();

            //Act
            evaluator.Add((val, additionalVals) => val && additionalVals[0] && additionalVals[1], false, true);
            bool result = evaluator.Evaluate(seed);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [Benchmark]
        public void Evaluator_Touple_Add_Null_Function_Throws_ArgumentNullException()
        {
            // Arrange
            var evaluator = new EvaluatorTouple<int>();

            //Assert
            Assert.ThrowsException<ArgumentNullException>(() => evaluator.Add(null));
        }
    }
}
