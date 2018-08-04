namespace Exercism_kindergarten_garden
{
    using System.Collections.Generic;
    using System.Linq;

    public enum Plant
    {
        Clover,
        Grass,
        Radishes,
        Violets
    }

    public class Garden
    {
        private List<string> _children = new List<string>
        {
            "Alice", "Bob", "Charlie", "David",
            "Eve", "Fred", "Ginny", "Harriet",
            "Ileana", "Joseph", "Kincaid", "Larry"
        };

        private Dictionary<char, Plant> plantMap = new Dictionary<char, Plant>
        {
            ['C'] = Plant.Clover,
            ['G'] = Plant.Grass,
            ['R'] = Plant.Radishes,
            ['V'] = Plant.Violets
        };

        private string plantsRow1;

        private string plantsRow2;

        public static Garden DefaultGarden(string plantsDiagram)
        {
            return new Garden(null, plantsDiagram);
        }

        public Garden(string[] children, string plantsDiagram)
        {
            if (children != null)
            {
                _children = children.OrderBy(e => e).ToList();
            }

            string[] plantsRows = plantsDiagram.Split('\n');

            plantsRow1 = plantsRows[0];
            plantsRow2 = plantsRows[1];
        }

        public Plant[] GetPlants(string childName)
        {
            int childNumber = _children.IndexOf(childName);
            if (childNumber == -1)
            {
                return new Plant[0];
            }

            var plantsInRow1 = plantsRow1.Skip(childNumber * 2).Take(2).Select(e => plantMap[e]);
            var plantsInRow2 = plantsRow2.Skip(childNumber * 2).Take(2).Select(e => plantMap[e]);

            return plantsInRow1.Concat(plantsInRow2).ToArray();
        }
    }
}
