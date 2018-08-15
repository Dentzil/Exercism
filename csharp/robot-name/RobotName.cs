using System;
using System.Collections.Generic;
using System.Linq;

public class Robot
{
    private const int LettersLength = 2;
    private const int NumbersLength = 3;

    private static Random rand = new Random();
    private static HashSet<string> robotNames = new HashSet<string>();

    public string Name { get; private set; }

    public Robot()
    {
        GenerateRobotName();
    }

    public void Reset()
    {
        robotNames.Remove(Name);
        Name = null;
    }

    private void GenerateRobotName()
    {
        string generatedName;

        do
        {
            generatedName = string.Empty;
            generatedName += string.Concat(Enumerable.Range(0, LettersLength).Select(e => (char)rand.Next(65, 91)));
            generatedName += string.Concat(Enumerable.Range(0, NumbersLength).Select(e => rand.Next(0, 10)));
        } while (robotNames.Add(generatedName));

        Name = generatedName;
    }
}
