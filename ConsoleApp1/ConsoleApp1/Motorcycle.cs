namespace TransportChallenge;

public class Motorcycle : Vehicle, IDriveable
{
    public Motorcycle() : base("Motorcycle") { }

    public override string Move() => "Driving on the road.";

    public void Drive()
    {
        System.Console.WriteLine(Move());
    }
}