namespace Tamrin2
{
    public class CanRunFast : CanNotFly
    {
        public CanRunFast(string name) : base(name)
        {
        }

        public override string WhoAmI() => base.WhoAmI() + ", I can run fast!";
    }
}