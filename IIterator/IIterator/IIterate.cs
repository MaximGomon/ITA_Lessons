namespace Iterator
{
    public interface IIterate<TEntity>
    {
        TEntity First();
        TEntity MoveNext();
        bool IsDone();
        TEntity CurrentItem();
    }
}