namespace Tamrin2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (var bird in GetBirds())
            {
                Console.WriteLine(bird.WhoAmI());
            }

            Console.ReadKey();
        }

        static IEnumerable<IBird> GetBirds()
        {
            yield return new CanRunFast("A");
            yield return new CanReach100Meter("B");
            yield return new CanReach200Meter("C");
            yield return new CanReach200Meter("D");
            yield return new CanNotRunFast("E");
            yield return new CanReach500Meter("F");
            yield return new CanRunFast("G");
            yield return new CanReach500Meter("H");
            yield return new CanReach500Meter("I");
            yield return new CanRunFast("J");
        }
    }
}