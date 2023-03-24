namespace Tamrin2
{
    public class CanReach500Meter : CanFly
    {
        public CanReach500Meter(string name) : base(name)
        {
        }

        public override string WhoAmI() => base.WhoAmI() + ", I can reach 500 meter in height!";
    }
}