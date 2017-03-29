using System.Collections;
using System.Collections.Generic;

namespace IteratorSample
{
    public class CustomCollection<T> : IAggregate<T>
    {
        private readonly List<T> _items = new List<T>();

        public IIterator GetIterator()
        {
            return new CollectionIterator<T>(this);
        }

        public int Count
        {
            get { return _items.Count; }
            set { }
        }

        public T this[int index]
        {
            get { return _items[index]; }
            set { _items.Insert(index, value); }
        }
    }
}