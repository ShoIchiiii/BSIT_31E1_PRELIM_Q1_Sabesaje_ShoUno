namespace TransportChallenge;

public class Boat : Vehicle, ISailable
{
    public Boat() : base("Boat") { }

    public override string Move() => "Sailing on the water.";

    public void Sail()
    {
        System.Console.WriteLine(Move());
    }
}