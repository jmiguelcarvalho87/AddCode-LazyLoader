using System;
using System.Collections.Generic;

namespace LazyLoader
{
    public class EvaluatorTouple<T> : IEvaluator<T>
    {
        private List<(Func<T, T[], T> Function, T[] AdditionalArgs)> funcToupleList;

        public EvaluatorTouple()
        {
            this.funcToupleList = new List<(Func<T, T[], T>, T[])>();
        }

        public void Add(Func<T, T[], T> func, params T[] additionalArgs)
        {
            if (func == null)
                throw new ArgumentNullException("func", "func argument of type Func<T, T[], T> cannot be null.");

            funcToupleList.Add((func, additionalArgs));
        }

        public T Evaluate(T seed)
        {
            foreach (var funcTouple in funcToupleList)
                seed = funcTouple.Function(seed, funcTouple.AdditionalArgs);

            return seed;
        }
    }
}
