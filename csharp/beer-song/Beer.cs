namespace Exercism_beer_song
{
    using System.Collections.Generic;

    public class Beer
    {
        public static string Verse(int number)
        {
            string bottlesOnTheWall = GetBottlesOnTheWall(number);

            string takeBottleOrGoToBuy = TakeBottleOrGoToBuy(number);

            string leftBottlesOnTheWall = GetLeftBottlesOnTheWall(number);

            return $"{bottlesOnTheWall} of beer on the wall, {bottlesOnTheWall.ToLower()} of beer.\n" +
                $"{takeBottleOrGoToBuy}, {leftBottlesOnTheWall.ToLower()} of beer on the wall.\n";
        }

        public static string Sing(int start, int end)
        {
            List<string> song = new List<string>();

            for (int i = start; i >= end; i--)
            {
                song.Add(Verse(i) + "\n");
            }

            return string.Concat(song);
        }

        private static string GetBottlesOnTheWall(int number)
        {
            if (number > 1)
            {
                return $"{number} bottles";
            }

            if (number == 1)
            {
                return $"{number} bottle";
            }

            return "No more bottles";
        }

        private static string TakeBottleOrGoToBuy(int number)
        {
            if (number > 1)
            {
                return "Take one down and pass it around";
            }

            if (number == 1)
            {
                return "Take it down and pass it around";
            }

            return "Go to the store and buy some more";
        }

        private static string GetLeftBottlesOnTheWall(int number)
        {
            number = --number == -1 ? 99 : number;

            return GetBottlesOnTheWall(number);
        }
    }
}
