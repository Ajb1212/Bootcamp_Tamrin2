namespace Tamrin2
{
    public abstract class CanFly : Bird
    {
        protected CanFly(string name) : base(name)
        {
        }

        public override string WhoAmI() => "I can fly";
    }
}