using System;
using System.Collections.Generic;
using System.Text;

namespace LazyLoader
{
    public class AddedFunc<T> : IAddedFunc<T>
    {
        public Func<T, T[], T> Func { get; set; }
        public T[] AdditionalArgs { get; set; }
    }
}
