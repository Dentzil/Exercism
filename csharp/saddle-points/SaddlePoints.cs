namespace Exercism_saddle_points
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SaddlePoints
    {
        private struct Point
        {
            public int X;
            public int Y;

            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }
        }

        private List<Point> _saddlePoints = new List<Point>();

        public SaddlePoints(int[,] values)
        {
            int rows = values.GetLength(0);
            int columns = values.GetLength(1);

            int[] maxInRows = new int[rows];
            for (int i = 0; i < rows; i++)
            {
                maxInRows[i] = values.FindMaxInRow(i);
            }

            int[] minInColumns = new int[columns];
            for (int i = 0; i < columns; i++)
            {
                minInColumns[i] = values.FindMinInColumn(i);
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (values[i, j] == maxInRows[i] && values[i, j] == minInColumns[j])
                    {
                        _saddlePoints.Add(new Point(i, j));
                    }
                }
            }
        }

        public IEnumerable<Tuple<int, int>> Calculate() => _saddlePoints.Select(e => Tuple.Create(e.X, e.Y));
    }

    public static class TwoDArrayExtensions
    {
        public static int FindMaxInRow(this int[,] array, int row)
        {
            return Enumerable.Range(0, array.GetLength(1)).Max(e => array[row, e]);
        }

        public static int FindMinInColumn(this int[,] array, int column)
        {
            return Enumerable.Range(0, array.GetLength(0)).Min(e => array[e, column]);
        }
    }
}
