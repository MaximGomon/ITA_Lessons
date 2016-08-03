using System.Collections;
using System.Collections.Generic;

namespace WcfExample
{
    public class MyList<TEntity> : ICollection<TEntity> where TEntity : Opperand
    {
        public IEnumerator<TEntity> GetEnumerator()
        {
            throw new System.NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(TEntity item)
        {
            throw new System.NotImplementedException();
        }

        public void Clear()
        {
            throw new System.NotImplementedException();
        }

        public bool Contains(TEntity item)
        {
            throw new System.NotImplementedException();
        }

        public void CopyTo(TEntity[] array, int arrayIndex)
        {
            throw new System.NotImplementedException();
        }

        public bool Remove(TEntity item)
        {
            throw new System.NotImplementedException();
        }

        public int Count { get; }
        public bool IsReadOnly { get; }
    }
}