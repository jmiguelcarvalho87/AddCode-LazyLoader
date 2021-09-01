``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19042.1165 (20H2/October2020Update)
AMD Ryzen 5 4500U with Radeon Graphics, 1 CPU, 6 logical and 6 physical cores
.NET SDK=5.0.400
  [Host]     : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT
  Job-QTYCDD : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

IterationCount=100  RunStrategy=Throughput  

```
|                                                                                             Method |        Mean |     Error |    StdDev |         Min |         Max |      Median |
|--------------------------------------------------------------------------------------------------- |------------:|----------:|----------:|------------:|------------:|------------:|
|                                                          Evaluator_Touple_For_Int_Should_Return_22 |   119.95 ns |  0.440 ns |  1.283 ns |   116.60 ns |   123.60 ns |   119.88 ns |
|                                 Evaluator_Touple_Should_Return_AddCode_Challenge_Is_Working_Nicely |   216.72 ns |  0.702 ns |  2.058 ns |   210.38 ns |   220.67 ns |   216.79 ns |
|                                                     Evaluator_Touple_With_No_Function_Returns_Seed |    31.68 ns |  0.093 ns |  0.264 ns |    31.24 ns |    32.47 ns |    31.64 ns |
|  Evaluator_Touple_For_Double_With_Seed_5_And_Function_Power_Of_2_With_No_Additional_Arg_Aeturns_25 |    87.67 ns |  0.243 ns |  0.673 ns |    86.20 ns |    89.43 ns |    87.55 ns |
| Evaluator_Touple_For_Boolean_With_Seed_TRUE_And_Additional_Args_TRUE_And_False_Should_Return_FALSE |    69.24 ns |  0.228 ns |  0.658 ns |    66.33 ns |    71.01 ns |    69.18 ns |
|                                    Evaluator_Touple_Add_Null_Function_Throws_ArgumentNullException | 7,017.37 ns | 13.756 ns | 38.345 ns | 6,961.11 ns | 7,136.14 ns | 7,011.49 ns |
