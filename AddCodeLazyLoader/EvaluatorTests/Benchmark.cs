using BenchmarkDotNet.Running;
using EvaluatorTests;

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

        //        |        EvaluatorQueueTests                                                                                    Method |        Mean |    Error |    StdDev |         Min |         Max |      Median |
        //|-------------------------------------------------------------------------------------------------- |------------:|---------:|----------:|------------:|------------:|------------:|
        //|                                                          Evaluator_Queue_For_Int_Should_Return_22 |   142.35 ns | 0.779 ns |  2.272 ns |   138.58 ns |   147.62 ns |   141.96 ns |
        //|                                 Evaluator_Queue_Should_Return_AddCode_Challenge_Is_Working_Nicely |   208.98 ns | 0.528 ns |  1.482 ns |   205.72 ns |   212.58 ns |   208.98 ns |
        //|                                                     Evaluator_Queue_With_No_Function_Returns_Seed |    24.09 ns | 0.063 ns |  0.174 ns |    23.35 ns |    24.52 ns |    24.09 ns |
        //|  Evaluator_Queue_For_Double_With_Seed_5_And_Function_Power_Of_2_With_No_Additional_Arg_Returns_25 |    83.81 ns | 0.589 ns |  1.641 ns |    81.68 ns |    88.24 ns |    83.49 ns |
        //| Evaluator_Queue_For_Boolean_With_Seed_TRUE_And_Additional_Args_TRUE_And_False_Should_Return_FALSE |    68.93 ns | 0.197 ns |  0.555 ns |    67.50 ns |    70.29 ns |    68.87 ns |
        //|                                    Evaluator_Queue_Add_Null_Function_Throws_ArgumentNullException | 7,071.26 ns | 8.238 ns | 23.636 ns | 7,019.78 ns | 7,142.92 ns | 7,067.09 ns |


        //        |           EvaluatorToupleTests                                                                                  Method |        Mean |     Error |    StdDev |         Min |         Max |      Median |
        //|--------------------------------------------------------------------------------------------------- |------------:|----------:|----------:|------------:|------------:|------------:|
        //|                                                          Evaluator_Touple_For_Int_Should_Return_22 |   119.95 ns |  0.440 ns |  1.283 ns |   116.60 ns |   123.60 ns |   119.88 ns |
        //|                                 Evaluator_Touple_Should_Return_AddCode_Challenge_Is_Working_Nicely |   216.72 ns |  0.702 ns |  2.058 ns |   210.38 ns |   220.67 ns |   216.79 ns |
        //|                                                     Evaluator_Touple_With_No_Function_Returns_Seed |    31.68 ns |  0.093 ns |  0.264 ns |    31.24 ns |    32.47 ns |    31.64 ns |
        //|  Evaluator_Touple_For_Double_With_Seed_5_And_Function_Power_Of_2_With_No_Additional_Arg_Aeturns_25 |    87.67 ns |  0.243 ns |  0.673 ns |    86.20 ns |    89.43 ns |    87.55 ns |
        //| Evaluator_Touple_For_Boolean_With_Seed_TRUE_And_Additional_Args_TRUE_And_False_Should_Return_FALSE |    69.24 ns |  0.228 ns |  0.658 ns |    66.33 ns |    71.01 ns |    69.18 ns |
        //|                                    Evaluator_Touple_Add_Null_Function_Throws_ArgumentNullException | 7,017.37 ns | 13.756 ns | 38.345 ns | 6,961.11 ns | 7,136.14 ns | 7,011.49 ns |
    }
}
