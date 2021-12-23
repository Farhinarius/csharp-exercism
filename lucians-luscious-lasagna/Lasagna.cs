public class Lasagna
{
    public static readonly int MinutesForLayers = 2;
    public int ExpectedMinutesInOven() => 40;

    public int RemainingMinutesInOven(int ovenMinutes) =>
        ExpectedMinutesInOven() - ovenMinutes;

    public int PreparationTimeInMinutes(int layers) => layers * MinutesForLayers;

    public int ElapsedTimeInMinutes(int layers, int ovenMinutes) => 
        PreparationTimeInMinutes(layers) + ovenMinutes;
}

