using System;

namespace LazyLoader
{
    public class AddedFunc<T> : IAddedFunc<T>
    {
        public Func<T, T[], T> Func { get; set; }
        public T[] AdditionalArgs { get; set; }
    }
}
