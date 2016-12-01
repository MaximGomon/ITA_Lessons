namespace Iterator
{
    public interface IAggregate<TType>
    {
        IIterate<TType> CreateIterator();//GetEnumerator()
        int Count();
        TType this[int index] { get; set; }
        void Add(TType entity);
    }
}