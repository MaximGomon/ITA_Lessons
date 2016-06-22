namespace WF2
{
    public class Mountain : Bike
    {
        public Mountain(int id) : base(id)
        {
        }
        public override string ToString()
        {
            return string.Format("{0};{1};{2};{3}", Id, Name, Size, BikeType.Mountain);
        }
    }
}