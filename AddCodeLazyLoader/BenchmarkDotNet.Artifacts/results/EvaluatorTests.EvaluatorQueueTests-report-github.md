``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19042.1165 (20H2/October2020Update)
AMD Ryzen 5 4500U with Radeon Graphics, 1 CPU, 6 logical and 6 physical cores
.NET SDK=5.0.400
  [Host]     : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT
  Job-IIQMDO : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

IterationCount=100  RunStrategy=Throughput  

```
|                                                                                            Method |        Mean |    Error |    StdDev |         Min |         Max |      Median |
|-------------------------------------------------------------------------------------------------- |------------:|---------:|----------:|------------:|------------:|------------:|
|                                                          Evaluator_Queue_For_Int_Should_Return_22 |   142.35 ns | 0.779 ns |  2.272 ns |   138.58 ns |   147.62 ns |   141.96 ns |
|                                 Evaluator_Queue_Should_Return_AddCode_Challenge_Is_Working_Nicely |   208.98 ns | 0.528 ns |  1.482 ns |   205.72 ns |   212.58 ns |   208.98 ns |
|                                                     Evaluator_Queue_With_No_Function_Returns_Seed |    24.09 ns | 0.063 ns |  0.174 ns |    23.35 ns |    24.52 ns |    24.09 ns |
|  Evaluator_Queue_For_Double_With_Seed_5_And_Function_Power_Of_2_With_No_Additional_Arg_Returns_25 |    83.81 ns | 0.589 ns |  1.641 ns |    81.68 ns |    88.24 ns |    83.49 ns |
| Evaluator_Queue_For_Boolean_With_Seed_TRUE_And_Additional_Args_TRUE_And_False_Should_Return_FALSE |    68.93 ns | 0.197 ns |  0.555 ns |    67.50 ns |    70.29 ns |    68.87 ns |
|                                    Evaluator_Queue_Add_Null_Function_Throws_ArgumentNullException | 7,071.26 ns | 8.238 ns | 23.636 ns | 7,019.78 ns | 7,142.92 ns | 7,067.09 ns |
