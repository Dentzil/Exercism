namespace Exercism_allergies
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Allergies
    {
        private Dictionary<int, string> _allergiesMap = new Dictionary<int, string>
        {
            [1] = "eggs",
            [2] = "peanuts",
            [4] = "shellfish",
            [8] = "strawberries",
            [16] = "tomatoes",
            [32] = "chocolate",
            [64] = "pollen",
            [128] = "cats"
        };

        private HashSet<string> _allergies = new HashSet<string>();

        public Allergies(int mask)
        {
            _allergiesMap
                .Where(e => (e.Key & mask) == e.Key)
                .ToList()
                .ForEach(e => _allergies.Add(e.Value));
        }

        public bool AllergicTo(string allergy)
        {
            return _allergies.Contains(allergy);
        }

        public IList<string> List()
        {
            return _allergies.ToList();
        }
    }
}
