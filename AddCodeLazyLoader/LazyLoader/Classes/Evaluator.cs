using System;
using System.Collections.Generic;

namespace LazyLoader
{
    public class Evaluator<T> : IEvaluator<T>
    {
        List<(Func<T, T[], T>, T[])> funcToupleList;

        public Evaluator()
        {
            funcToupleList = new List<(Func<T, T[], T>, T[])>();
        }

        public void Add(Func<T, T[], T> func, params T[] additionalArgs)
        {
            if (func == null)
                throw new System.ArgumentException("Func cannot be null");

            funcToupleList.Add((func, additionalArgs));
        }

        public T Evaluate(T seed)
        {
            foreach (var funcTouple in funcToupleList)
                seed = funcTouple.Item1(seed, funcTouple.Item2);

            return seed;
        }
    }
}
