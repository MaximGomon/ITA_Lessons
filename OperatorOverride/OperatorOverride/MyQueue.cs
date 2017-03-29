namespace OperatorOverride
{
    public class MyQueue
    {
        public int ElementCount { get; set; }

        //public static explicit operator MyQueue(Chain item)
        //{
        //    return new MyQueue
        //    {
        //        ElementCount = item.CountOfElements
        //    };
        //}

        public static implicit operator Chain(MyQueue item)
        {
            return new Chain
            {
                CountOfElements = item.ElementCount
            };
        }

        public override string ToString()
        {
            return ElementCount.ToString();
        }
    }
}