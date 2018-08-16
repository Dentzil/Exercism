using System.Collections.Generic;
using System.Linq;

public class Etl
{
    public static Dictionary<string, int> Transform(Dictionary<int, string[]> old)
    {
        Dictionary<string, int> transformed = new Dictionary<string, int>();

        foreach (var element in old)
        {
            element.Value.ToList().ForEach(e => transformed[e.ToLower()] = element.Key);
        }

        return transformed;
    }
}
