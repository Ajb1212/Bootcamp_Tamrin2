namespace Tamrin2
{
    public class CanReach100Meter : CanFly
    {
        public CanReach100Meter(string name) : base(name)
        {
        }

        public override string WhoAmI() => base.WhoAmI() + ", I can reach 100 meter in height!";
    }
}