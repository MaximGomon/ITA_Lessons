namespace FruitExample
{
    public abstract class Fruit
    {
        protected Fruit(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }

        public override string ToString()
        {
            return Name;
        }
    }
}