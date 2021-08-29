using System;
using System.Collections.Generic;

namespace LazyLoader
{
    public class Evaluator<T> : IEvaluator<T>
    {
        private List<IAddedFunc<T>> addedFuncList = new List<IAddedFunc<T>>();

        public void Add(Func<T, T[], T> func, params T[] additionalArgs)
        {
            IAddedFunc<T> addedFunc = new AddedFunc<T>();

            addedFunc.Func = func;
            addedFunc.AdditionalArgs = additionalArgs;

            addedFuncList.Add(addedFunc);
        }

        public T Evaluate(T seed)
        {
            int i = 1;
            T result = addedFuncList[0].Func(seed, addedFuncList[0].AdditionalArgs);
            while (i < addedFuncList.Count)
            {
                result = addedFuncList[i].Func(result, addedFuncList[i].AdditionalArgs);
                i++;
            }

            return result;
        }
    }
}
