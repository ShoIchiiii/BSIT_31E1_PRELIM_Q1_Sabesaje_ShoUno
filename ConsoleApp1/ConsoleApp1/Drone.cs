namespace TransportChallenge;

public class Drone : Vehicle, Interfaces
{
    public Drone() : base("Drone") { }

    public override string Move() => "Flying in the sky.";

    public void Fly()
    {
        System.Console.WriteLine(Move());
    }
}