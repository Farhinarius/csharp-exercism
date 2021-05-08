using System;

public class SpaceAge
{
    private const double EARTH_YEAR_SECONDS = 31_557_600;
    private readonly double PLANET_SECONDS;
    public SpaceAge(int seconds) => PLANET_SECONDS = (double)seconds;

    private double Calculate(double orbitalPeriod) => PLANET_SECONDS / EARTH_YEAR_SECONDS / orbitalPeriod;

    public double OnEarth() => Calculate(1.0);

    public double OnMercury() => Calculate(0.2408467);

    public double OnVenus() => Calculate(0.61519726);

    public double OnMars() => Calculate(1.8808158);

    public double OnJupiter() => Calculate(11.862615);

    public double OnSaturn() => Calculate(29.447498);

    public double OnUranus() => Calculate(84.016846);

    public double OnNeptune() => Calculate(164.79132);
}