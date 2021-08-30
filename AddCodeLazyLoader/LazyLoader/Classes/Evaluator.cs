using System;
using System.Collections.Generic;

namespace LazyLoader
{
    public class Evaluator<T> : IEvaluator<T>
    {
        List<Tuple<Func<T, T[], T>, T[]>> funcToupleList;

        public Evaluator()
        {
            funcToupleList = new List<Tuple<Func<T, T[], T>, T[]>>();
        }

        public void Add(Func<T, T[], T> func, params T[] additionalArgs)
        {
            if (func == null)
                throw new System.ArgumentException("Func cannot be null");

            funcToupleList.Add(new Tuple<Func<T, T[], T>, T[]>(func, additionalArgs));
        }

        public T Evaluate(T seed)
        {
            foreach (var touple in funcToupleList)
                seed = touple.Item1(seed, touple.Item2);

            return seed;
        }
    }
}
