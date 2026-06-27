namespace TransportChallenge;

public abstract class Vehicle
{
    public string Name { get; protected set; }

    protected Vehicle(string name)
    {
        Name = name;
    }

    public abstract string Move();
}