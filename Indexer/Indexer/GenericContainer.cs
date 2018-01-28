using System;
using System.Linq;

namespace Indexer
{
    public class GenericContainer<T> where T : Fruits
    {
        private readonly T[] _array;
        private int _currentIndex = 0;
        private readonly int _count;

        public GenericContainer(int count)
        {
            _count = count;
            _array = new T[count];
        }

        public int Count
        {
            get { return _count; }
        }

        public void AddElement(T item)
        {
            if (_count > _currentIndex)
            {
                _array[_currentIndex] = item;
                _currentIndex++;
                return;
            }
            throw new OverflowException();
        }

        private T GetElementByIndex(int index)
        {
            if (index < _count && index >= 0)
            {
                return _array[index];
            }
            throw new IndexOutOfRangeException();
        }

        public void RemoveElement(T item)
        {
            for (int i = 0; i < _count; i++)
            {
                if (_array[i].Equals(item))
                {
                    _array[i] = null;
                    break;
                }
            }
        }

        public T[] GetAllElements()
        {
            return _array.Where(x => x != null).ToArray();
        }

        public T this[int index]
        {
            get{ return GetElementByIndex(index); }
            set { _array[index] = value; }
        }
    }
}