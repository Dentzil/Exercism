using System; 
using System.Diagnostics;

public static class RealNumberExtension
{
    public static double Expreal(this int realNumber, RationalNumber r)
    {
        return r.Expreal(realNumber);
    }
}

public struct RationalNumber
{
    public readonly int Numerator;
    public readonly int Denominator;

    public RationalNumber(int numerator, int denominator)
    {
        Numerator = numerator;
        Denominator = denominator;
    }

    public RationalNumber Add(RationalNumber r)
    {
        int newNumerator = Numerator * r.Denominator + r.Numerator * Denominator;
        int newDenominator = Denominator * r.Denominator;

        return new RationalNumber(newNumerator, newDenominator).Reduce();
    }

    public static RationalNumber operator +(RationalNumber r1, RationalNumber r2)
    {
        return r1.Add(r2);
    }

    public RationalNumber Sub(RationalNumber r)
    {
        int newNumerator = Numerator * r.Denominator - r.Numerator * Denominator;
        int newDenominator = Denominator * r.Denominator;

        return new RationalNumber(newNumerator, newDenominator).Reduce();
    }

    public static RationalNumber operator -(RationalNumber r1, RationalNumber r2)
    {
        return r1.Sub(r2);
    }

    public RationalNumber Mul(RationalNumber r)
    {
        int newNumerator = Numerator * r.Numerator;
        int newDenominator = Denominator * r.Denominator;

        return new RationalNumber(newNumerator, newDenominator).Reduce();
    }

    public static RationalNumber operator *(RationalNumber r1, RationalNumber r2)
    {
        return r1.Mul(r2);
    }

    public RationalNumber Div(RationalNumber r)
    {
        int newNumerator = (Numerator * r.Denominator) * Math.Sign(r.Numerator);
        int newDenominator = Math.Abs(r.Numerator) * Denominator;

        return new RationalNumber(newNumerator, newDenominator).Reduce();
    }

    public static RationalNumber operator /(RationalNumber r1, RationalNumber r2)
    {
        return r1.Div(r2);
    }

    public RationalNumber Abs()
    {
        return new RationalNumber(Math.Abs(Numerator), Math.Abs(Denominator)).Reduce();
    }

    public RationalNumber Reduce()
    {
        var gcd = GCD(Math.Abs(Numerator), Math.Abs(Denominator));
        var sign = Math.Sign(Numerator) * Math.Sign(Denominator);

        return new RationalNumber(sign * Math.Abs(Numerator) / gcd, Math.Abs(Denominator) / gcd);
    }

    public RationalNumber Exprational(int power)
    {
        int newNumerator;
        int newDenominator;

        if (power >= 0)
        {
            newNumerator = (int)Math.Pow(Numerator, power);
            newDenominator = (int)Math.Pow(Denominator, power);
        }
        else
        {
            newNumerator = (int)Math.Pow(Denominator, -power);
            newDenominator = (int)Math.Pow(Numerator, -power);
        }

        return new RationalNumber(newNumerator, newDenominator).Reduce();
    }

    public double Expreal(int baseNumber)
    {
        return Math.Pow(Math.Pow(baseNumber, Numerator), 1.0 / Denominator);
    }

    private int GCD(int a, int b)
    {
        return b == 0 ? a : GCD(b, a % b);
    }
}
