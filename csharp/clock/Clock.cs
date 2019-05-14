using System;

public class Clock : IEquatable<Clock>
{
    private const int MinutesPerHour = 60;
    private const int MinutesPerDay = 1440;

    private readonly int _hours;
    private readonly int _minutes;
    private readonly int _totalMinutes;

    public Clock(int hours, int minutes = 0)
    {
        _totalMinutes = (hours * MinutesPerHour + minutes) % MinutesPerDay;
        if (_totalMinutes < 0)
        {
            _totalMinutes += MinutesPerDay;
        }

        _hours = _totalMinutes / MinutesPerHour;
        _minutes = _totalMinutes % MinutesPerHour;
    }

    public Clock Add(int minutes)
    {
        int newTotalMinutes = (_totalMinutes + minutes) % MinutesPerDay;

        return new Clock(0, newTotalMinutes);
    }

    public bool Equals(Clock other)
    {
        if (other == null)
        {
            return false;
        }

        return _totalMinutes == other._totalMinutes;
    }

    public override bool Equals(object obj)
    {
        return obj is Clock ? Equals((Clock)obj) : false;        
    }

    public override int GetHashCode()
    {
        return _totalMinutes.GetHashCode();
    }

    public Clock Subtract(int minutes)
    {
        int newTotalMinutes = (_totalMinutes - minutes) % MinutesPerDay;
        if  (newTotalMinutes < 0)
        {
            newTotalMinutes += MinutesPerDay;
        }

        return new Clock(0, newTotalMinutes);
    }

    public override string ToString()
    {
        return $"{_hours:D2}:{_minutes:D2}";
    }
}
