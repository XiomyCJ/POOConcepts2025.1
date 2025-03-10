using System;

using Geometry;

public class Kite : Rhombus
{
    private double _b;

    public double B
    {
        get => _b;
        set => _b = ValidateB(value);
    }
    private double ValidateB(double side)
    {
        if (side < 0)
        {
            throw new ArgumentException($"El lado {side}, no es valido.");
        }
        return side;
    }

    public Kite(string name, double side1, double diagonal1, double diagonal2, double side2) : base(name, side1, diagonal1, diagonal2)
    {
        _b = ValidateB(side2);
    }

    public override double GetArea()
    {
        return D1 * D2 / 2;
    }

    public override double GetPerimeter()
    {
        return 2 * (A + B);
    }
}