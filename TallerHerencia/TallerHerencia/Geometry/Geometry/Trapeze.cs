using System;

using Geometry;

public class Trapeze : Triangle
{
    private double _d;

    public double D
    {
        get => _d;
        set => _d = ValidateD(value);
    }
    private double ValidateD(double base1)
    {
        if (base1 < 0)
        {
            throw new ArgumentException($"la base {base1}, no es valida.");
        }
        return base1;
    }

    public Trapeze(string name, double base1, double side1, double side2, double base2, double height) : base(name, side1, base1, side2, height)
    {
        _d = ValidateD(base2);
    }

    public override double GetArea()
    {
        return (B + D) * H / 2;
    }

    public override double GetPerimeter()
    {
        return A + B + C + D;
    }
}