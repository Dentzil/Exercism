using System;

public class QueenAttack
{
    public int Row { get; private set; }
    public int Column { get; private set; }

    public QueenAttack(int row, int column)
    {
        if (row < 0 || row >= 8 || column < 0 || column >= 8)
        {
            throw new ArgumentOutOfRangeException();
        }

        Row = row;
        Column = column;
    }

    public static QueenAttack Create(int row, int column)
    {
        return new QueenAttack(row, column);
    }

    public static bool CanAttack(QueenAttack queen1, QueenAttack queen2)
    {
        if (queen1 == null || queen2 == null || queen1.Equals(queen2))
        {
            throw new ArgumentException();
        }

        if (queen1.Row != queen2.Row
            && queen1.Column != queen2.Column
            && Math.Abs(queen1.Row - queen2.Row) != Math.Abs(queen1.Column - queen2.Column))
        {
            return false;
        }

        return true;
    }

    public override bool Equals(object obj)
    {
        QueenAttack other = obj as QueenAttack;
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
