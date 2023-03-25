namespace Tamrin2
{
    public abstract class CanNotFly : Bird
    {
        protected CanNotFly(string name) : base(name)
        {
        }

        public override string WhoAmI() => "I can not fly";
    }
}