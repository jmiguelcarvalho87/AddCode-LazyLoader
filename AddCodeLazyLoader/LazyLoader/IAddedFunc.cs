using System;

namespace LazyLoader
{
    public interface IAddedFunc<T>
    {
        T[] AdditionalArgs { get; set; }
        Func<T, T[], T> Func { get; set; }
    }
}