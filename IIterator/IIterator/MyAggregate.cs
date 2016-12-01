using System.Collections;

namespace Iterator
{
    public class MyAggregate<TType> : IAggregate<TType> where TType : class 
    {
        private readonly ArrayList _items = new ArrayList();

        public IIterate<TType> CreateIterator()
        {
            return new MyIterator<TType>(this);
        }

        public int Count()
        {
            return _items.Count;
        }

        public void Add(TType entity)
        {
            _items.Add(entity);
        }

        public TType this[int index]
        {
            get {return (TType)_items[index]; }
            set { _items.Add(value);}
        } 
    }
}