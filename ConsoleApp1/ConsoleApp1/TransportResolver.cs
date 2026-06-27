namespace TransportChallenge;

public static class TransportResolver
{
    private static readonly System.Collections.Generic.Dictionary<string, System.Func<Vehicle>> _registry =
        new(System.StringComparer.OrdinalIgnoreCase)
        {
            { "car", () => new Car() },
            { "plane", () => new Airplane() },
            { "boat", () => new Boat() },
            { "helicopter", () => new Helicopter() },
            { "motorcycle", () => new Motorcycle() },
            { "submarine", () => new Submarine() },
            { "drone", () => new Drone() }
        };

    public static Vehicle? Resolve(string transportType)
    {
        if (string.IsNullOrWhiteSpace(transportType)) return null;

        if (_registry.TryGetValue(transportType, out var factory))
        {
            return factory();
        }

        return null;
    }
}