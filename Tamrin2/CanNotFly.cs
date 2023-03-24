namespace Tamrin2
{
    public abstract class CanNotFly : IBird
    {
        public CanNotFly(string name) => Name = name;

        public string Name { get; }
        public virtual string WhoAmI() => "I can not fly";
    }
}