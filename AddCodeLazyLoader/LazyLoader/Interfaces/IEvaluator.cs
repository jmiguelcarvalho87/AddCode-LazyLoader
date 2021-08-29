using System;

namespace LazyLoader
{
    public interface IEvaluator<T>
    {
        void Add(Func<T, T[], T> func, params T[] additionalArgs);
        public T Evaluate(T seed);
    }
}
