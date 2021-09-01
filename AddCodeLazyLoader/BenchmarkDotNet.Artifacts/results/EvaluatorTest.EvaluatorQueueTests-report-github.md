``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19042.1165 (20H2/October2020Update)
AMD Ryzen 5 4500U with Radeon Graphics, 1 CPU, 6 logical and 6 physical cores
.NET SDK=5.0.400
  [Host]     : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT
  Job-UBFOWK : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

IterationCount=100  RunStrategy=Throughput  

```
|                           Method |     Mean |   Error |  StdDev |   Median |      Min |      Max |
|--------------------------------- |---------:|--------:|--------:|---------:|---------:|---------:|
| Evaluator_Queue_Should_Return_22 | 167.5 ns | 2.48 ns | 7.15 ns | 165.5 ns | 157.7 ns | 187.8 ns |
