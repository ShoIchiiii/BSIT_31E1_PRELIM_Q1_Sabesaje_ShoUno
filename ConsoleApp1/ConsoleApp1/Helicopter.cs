namespace TransportChallenge;

public class Helicopter : Vehicle, Interfaces, IDriveable
{
    public Helicopter() : base("Helicopter") { }

    public override string Move() => "Flying in the sky.";

    public void Fly()
    {
        System.Console.WriteLine(Move());
    }

    public void Drive()
    {
        System.Console.WriteLine("Taxis on the runway.");
    }
}