namespace Tamrin2
{
    public abstract class Bird : IBird
    {
        public Bird(string name) => Name = name;
        public string Name { get; }
        public abstract string WhoAmI();
    }
}