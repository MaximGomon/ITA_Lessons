namespace Builder
{
    public class Gudget
    {
        public string Power { get; set; }
        public string Keyboard { get; set; }
        public string Monitor { get; set; }

        public override string ToString()
        {
            return $"{Monitor} {Keyboard} {Power}";
        }
    }
}