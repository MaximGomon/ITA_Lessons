namespace WF2
{
    public abstract class Bike
    {
        public readonly int Id;
        public string Name { get; set; }
        public int Size { get; set; }

        protected Bike(int id)
        {
            Id = id;
        }
        
    }
}