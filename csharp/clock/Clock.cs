namespace Exercism_clock
{
    public class Clock
    {
        private const int MinutesInHour = 60;

        private const int MinutesInDay = 1440;

        private readonly int _minutes;

        public Clock(int hours, int minutes = 0)
        {
            _minutes = (hours * MinutesInHour + minutes) % MinutesInDay;
        }

        public Clock Add(int minutes)
        {
            int newTime = (_minutes + minutes) % MinutesInDay;

            return new Clock(0, newTime);
        }

        public override bool Equals(object obj)
        {
            Clock other = obj as Clock;
            if (other == null)
            {
                return false;
            }

            return _minutes == other._minutes;
        }

        public override int GetHashCode()
        {
            return _minutes.GetHashCode();
        }

        public Clock Subtract(int minutes)
        {
            int newTime = _minutes - minutes;
            if (newTime < 0)
            {
                newTime = MinutesInDay + newTime;
            }

            return new Clock(0, newTime);
        }

        public override string ToString()
        {
            return $"{_minutes / MinutesInHour:D2}:{_minutes % MinutesInHour:D2}";
        }


    }
}
