namespace Exercism_space_age
{
    public class SpaceAge
    {
        private const double OrbitalPeriodOnEarthInSeconds = 31557600.0;

        public long Seconds { get; }

        public double OnEarth { get; }

        public double OnMercury { get; }

        public double OnVenus { get; }

        public double OnMars { get; }

        public double OnJupiter { get; }

        public double OnSaturn { get; }

        public double OnUranus { get; }

        public double OnNeptune { get; }

        public SpaceAge(long ageInSeconds)
        {
            Seconds = ageInSeconds;

            OnEarth = Seconds / OrbitalPeriodOnEarthInSeconds;
            OnMercury = Seconds / (OrbitalPeriodOnEarthInSeconds * 0.2408467);
            OnVenus = Seconds / (OrbitalPeriodOnEarthInSeconds * 0.61519726);
            OnMars = Seconds / (OrbitalPeriodOnEarthInSeconds * 1.8808158);
            OnJupiter = Seconds / (OrbitalPeriodOnEarthInSeconds * 11.862615);
            OnSaturn = Seconds / (OrbitalPeriodOnEarthInSeconds * 29.447498);
            OnUranus = Seconds / (OrbitalPeriodOnEarthInSeconds * 84.016846);
            OnNeptune = Seconds / (OrbitalPeriodOnEarthInSeconds * 164.79132);
        }
    }
}
