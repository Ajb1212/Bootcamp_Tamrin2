namespace Tamrin2
{
    public class CanNotRunFast : CanNotFly
    {
        public CanNotRunFast(string name) : base(name)
        {
        }

        public override string WhoAmI() => base.WhoAmI() + ", I can not run fast!";
    }
}