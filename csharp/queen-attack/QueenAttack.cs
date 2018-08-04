namespace Exercism_queen_attack
{
    using System;

    public class Queen
    {
        public int Row { get; private set; }

        public int Column { get; private set; }

        public Queen(int row, int column)
        {
            Row = row;

            Column = column;
        }

        public override bool Equals(object obj)
        {
            Queen other = obj as Queen;
            if (other == null)
            {
                return false;
            }

            return Row == other.Row && Column == other.Column;
        }

        public override int GetHashCode()
        {
            return new { Row, Column }.GetHashCode();
        }
    }

    public static class Queens
    {
        public static bool CanAttack(Queen white, Queen black)
        {
            if (white == null || black == null || white.Equals(black))
            {
                throw new ArgumentException();
            }

            if (white.Column != black.Column && white.Row != black.Row &&
            Math.Abs(white.Column - black.Column) != Math.Abs(white.Row - black.Row))
            {
                return false;
            }

            return true;
        }
    }
}
