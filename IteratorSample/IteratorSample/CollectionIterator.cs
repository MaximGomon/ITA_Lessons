using System;

namespace IteratorSample
{
    public class CollectionIterator<T> : IIterator
    {
        private readonly IAggregate<T> _aggregate;
        private int _current;

        public CollectionIterator(IAggregate<T> aggregate)
        {
            this._aggregate = aggregate;
        }

        public object First()
        {
            return _aggregate[0];
        }

        public object Next()
        {
            object ret = null;

            _current++;

            if (_current < _aggregate.Count)
            {
                ret = _aggregate[_current];
            }
            return ret;
        }

        public object CurrentItem()
        {
            return _aggregate[_current];
        }

        public bool IsDone()
        {
            return _current >= _aggregate.Count;
        }
    }
}