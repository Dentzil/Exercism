using System;

public static class Darts
{
    enum CircleScore
    {
        Inner = 10,
        Middle = 5,
        Outer = 1
    }

    enum CircleRadius
    {
        Inner = 1,
        Middle = 5,
        Outer = 10
    }

    public static int Score(double x, double y)
    {
       int scores = 0;
       double distance = Math.Sqrt(x * x + y * y);

       if (distance <= (int) CircleRadius.Inner)
       {
           scores += (int) CircleScore.Inner;
       }
       else if (distance <= (int) CircleRadius.Middle)
       {
           scores += (int) CircleScore.Middle;
       }
       else if (distance <= (int) CircleRadius.Outer)
       {
           scores += (int) CircleScore.Outer;
       }

       return scores;
    }
}
