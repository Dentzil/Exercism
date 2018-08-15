public class SpaceAge
{
    private const double OrbitalPeriodOnEarthInSeconds = 31557600.0;
    private double _onEarth;
    private double _onJupiter;
    private double _onMars;
    private double _onMercury;
    private double _onNeptune;
    private double _onSaturn;
    private double _onUranus;
    private double _onVenus;   

    public SpaceAge(long ageInSeconds)
    {
        _onEarth = ageInSeconds / OrbitalPeriodOnEarthInSeconds;
        _onJupiter = ageInSeconds / (OrbitalPeriodOnEarthInSeconds * 11.862615);
        _onMars = ageInSeconds / (OrbitalPeriodOnEarthInSeconds * 1.8808158);
        _onMercury = ageInSeconds / (OrbitalPeriodOnEarthInSeconds * 0.2408467);
        _onNeptune = ageInSeconds / (OrbitalPeriodOnEarthInSeconds * 164.79132);
        _onSaturn = ageInSeconds / (OrbitalPeriodOnEarthInSeconds * 29.447498);
        _onUranus = ageInSeconds / (OrbitalPeriodOnEarthInSeconds * 84.016846);
        _onVenus = ageInSeconds / (OrbitalPeriodOnEarthInSeconds * 0.61519726);
    }

    public double OnEarth() => _onEarth;
    public double OnJupiter() => _onJupiter;
    public double OnMars() => _onMars;
    public double OnMercury() => _onMercury;
    public double OnNeptune() => _onNeptune;
    public double OnSaturn() => _onSaturn;
    public double OnUranus() => _onUranus;
    public double OnVenus() => _onVenus;
}
