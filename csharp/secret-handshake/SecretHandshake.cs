namespace Exercism_secret_handshake
{
    using System;
    using System.Collections.Generic;

    public static class SecretHandshake
    {
        private static Tuple<int, string>[] eventCommandValueMap =
        {
            Tuple.Create(1, "wink"),
            Tuple.Create(2, "double blink"),
            Tuple.Create(4, "close your eyes"),
            Tuple.Create(8, "jump")
        };

        public static string[] Commands(int commandValue)
        {
            if (commandValue < 0 || commandValue > 31)
            {
                throw new ArgumentOutOfRangeException($"Wrong command: {commandValue}");
            }

            List<string> events = new List<string>();

            foreach (var element in eventCommandValueMap)
            {
                if ((commandValue & element.Item1) == element.Item1)
                {
                    events.Add(element.Item2);
                }
            }

            if ((commandValue & 16) == 16)
            {
                events.Reverse();
            }

            return events.ToArray();
        }
    }
}
