using System;
using System.Linq;
using System.Collections.Generic;

public class Matrix
{
    private readonly int[][] _matrix;

    public Matrix(string input)
    {
        _matrix = ParseMatrix(input);
        VerifyMatrix();

        Rows = GetRowsCount();
        Cols = GetColumnsCount();
    }

    public int Rows { get; }

    public int Cols { get; }

    public int[] Row(int row)
    {
        if (row < 0 || row >= Rows)
        {
            throw new ArgumentException($"Invalid row: {row}");
        }

        return _matrix[row];
    }

    public int[] Column(int col)
    {
        if (col < 0 || col >= Cols)
        {
            throw new ArgumentException($"Invalid column: {col}");
        }

        return _matrix.Select(e => e[col]).ToArray();
    }

    private int[][] ParseMatrix(string input)
    {
        var matrix = new List<int[]>();

        var rows = input.Split('\n', StringSplitOptions.RemoveEmptyEntries);

        foreach (var row in rows)
        {
            var cols = row.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                          .Select(ParseElement)
                          .ToArray();
            
            if (cols.Length > 0)
            {
                matrix.Add(cols);
            }
        }

        return matrix.ToArray();
    }

    private int ParseElement(string element)
    {
        int intValue;
        if (!int.TryParse(element, out intValue))
        {
            throw new ArgumentException($"Invalid matrix element: {element}");
        }

        return intValue;
    }

    private void VerifyMatrix()
    {
        if (IsEmpty())
        {
            throw new ArgumentException("Matrix is empty");
        }

        if (HasDifferentColumnsLength())
        {
            throw new ArgumentException("Matrix is invalid");
        }
    }

    private bool IsEmpty()
    {
        return _matrix.Length == 0;
    }

    private bool HasDifferentColumnsLength()
    {
        return _matrix.Any(e => e.Length != _matrix[0].Length);
    }

    private int GetRowsCount()
    {
        return _matrix.Length;
    }

    private int GetColumnsCount()
    {
        return _matrix[0].Length;
    }
}
