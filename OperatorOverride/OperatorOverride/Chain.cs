namespace OperatorOverride
{
    public class Chain
    {
        public int CountOfElements { get; set; }

        public static implicit operator MyQueue(Chain item)
        {
            return new MyQueue
            {
                ElementCount = item.CountOfElements
            };
        }

        public static Chain operator ++(Chain item)
        {
            item.CountOfElements++;
            return item;
        }

        public static Chain operator --(Chain item)
        {
            item.CountOfElements--;
            return item;
        }

        public static bool operator ==(Chain item, Chain item2)
        {
            return item?.CountOfElements == item2?.CountOfElements;
        }

        public static bool operator !=(Chain item, Chain item2)
        {
            return item?.CountOfElements != item2?.CountOfElements; ;
        }

        //public static explicit operator Chain(MyQueue item)
        //{
        //    return new Chain
        //    {
        //        CountOfElements = item.ElementCount
        //    };
        //}

        public override string ToString()
        {
            return CountOfElements.ToString();
        }
    }
}