namespace TransportChallenge;

public class Submarine : Vehicle, ISailable, IDiveable
{
    public Submarine() : base("Submarine") { }

    public override string Move() => "Sailing on the water.";

    public void Sail()
    {
        System.Console.WriteLine(Move());
    }

    public void Dive()
    {
        System.Console.WriteLine("Diving deep underwater.");
    }
}