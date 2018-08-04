namespace Exercism_robot_name
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Robot
    {
        private static Random rand = new Random();

        private static HashSet<string> robotNames = new HashSet<string>();

        private string _name;

        public string Name
        {
            get
            {
                if (_name == null)
                {
                    GenerateRobotName();
                }

                return _name;
            }
        }

        public void Reset()
        {
            robotNames.Remove(_name);

            _name = null;
        }

        private void GenerateRobotName()
        {
            string generatedName = null;

            do
            {
                generatedName += string.Concat(Enumerable.Range(0, 2).Select(e => (char)rand.Next(65, 91)));
                generatedName += string.Concat(Enumerable.Range(0, 3).Select(e => rand.Next(0, 10)));
            } while (robotNames.Contains(generatedName));

            robotNames.Add(generatedName);

            _name = generatedName;
        }
    }
}
