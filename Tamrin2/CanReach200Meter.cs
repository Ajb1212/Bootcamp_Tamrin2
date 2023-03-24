namespace Tamrin2
{
    public class CanReach200Meter : CanFly
    {
        public CanReach200Meter(string name) : base(name)
        {
        }

        public override string WhoAmI() => base.WhoAmI() + ", I can reach 200 meter in height!";
    }
}