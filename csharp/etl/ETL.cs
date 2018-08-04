namespace Exercism_etl
{
    using System.Collections.Generic;
    using System.Linq;

    public class ETL
    {
        public static Dictionary<string, int> Transform(Dictionary<int, IList<string>> old)
        {
            Dictionary<string, int> transformed = new Dictionary<string, int>();

            foreach (var element in old)
            {
                element.Value.ToList().ForEach(e => transformed[e.ToLower()] = element.Key);
            }

            return transformed;
        }
    }
}
