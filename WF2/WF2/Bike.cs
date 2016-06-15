namespace WF2
{
    public class Bike
    {
        public string Name { get; set; }
        public int Size { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}