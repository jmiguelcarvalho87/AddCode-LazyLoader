using LazyLoader;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EvaluatorTest
{
    [TestClass]
    public class EvaluatorTests
    {
        [TestMethod]
        public void Evaluator_Should_Return_22()
        {
            // Arrange
            Evaluator<int> evaluator = new Evaluator<int>();

            // Act
            evaluator.Add((val, additionalVals) => val / 2);
            evaluator.Add((val, additionalVals) => val + additionalVals[0], 5);
            evaluator.Add((val, additionalVals) => val + 1 + additionalVals[0], 20);
            evaluator.Add((val, additionalVals) => val - additionalVals[0] - additionalVals[1], 5, 3);

            int finalResult = evaluator.Evaluate(8);
            // Assert
            Assert.AreEqual(22, finalResult, "Final result is wrong");
        }

        [TestMethod]
        public void Evaluator_Should_Return_AddCode_Challenge_Is_Working_Nicely()
        {
            // Arrange
            Evaluator<string> evaluator = new Evaluator<string>();

            // Act
            evaluator.Add((val, additionalVals) => val + " challenge ");
            evaluator.Add((val, additionalVals) => val + additionalVals[0], "is ");
            evaluator.Add((val, additionalVals) => val + "working " + additionalVals[0], "nicely");

            string finalResult = evaluator.Evaluate("AddCode");
            // Assert
            Assert.AreEqual("AddCode challenge is working nicely", finalResult, "Final result is wrong");
        }
    }
}
