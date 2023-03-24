namespace Tamrin2
{
    public abstract class CanFly : IBird
    {
        public CanFly(string name) => Name = name;
        public string Name { get; }
        public virtual string WhoAmI() => "I can fly";
    }
}