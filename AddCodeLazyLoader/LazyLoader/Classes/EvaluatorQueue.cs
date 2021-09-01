using System;
using System.Collections.Generic;
using System.Text;

namespace LazyLoader
{
    public class EvaluatorQueue<T> : IEvaluator<T>
    {
        private readonly Queue<Func<T, T>> funcQueueList;

        public EvaluatorQueue()
        {
            this.funcQueueList = new Queue<Func<T, T>>();
        }

        public void Add(Func<T, T[], T> func, params T[] additionalArgs)
        {
            if (func == null)
                throw new ArgumentNullException("func", "func argument of type Func<T, T[], T> cannot be null.");

            this.funcQueueList.Enqueue(seed => func(seed, additionalArgs));
        }

        public T Evaluate(T seed)
        {
            while (this.funcQueueList.Count > 0)
            {
                var func = this.funcQueueList.Dequeue();
                return Evaluate(func(seed));
            }

            return seed;
        }
    }
}
