namespace Exercism_raindrops
{
    public class Raindrops
    {
        public static string Convert(int number)
        {
            string convertResult = string.Empty;

            if (number % 3 == 0)
            {
                convertResult += "Pling";
            }

            if (number % 5 == 0)
            {
                convertResult += "Plang";
            }

            if (number % 7 == 0)
            {
                convertResult += "Plong";
            }

            return convertResult == string.Empty ? number.ToString() : convertResult;
        }
    }
}
