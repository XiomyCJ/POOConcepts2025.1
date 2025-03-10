using System;

using Geometry;

public class Square : GeometricFigure
{
    private double _a;

    public double A
    {
        get => _a;
        set => _a = ValidateA(value);
    }
    private double ValidateA(double side)
    {
        if (side < 0)
        {
            throw new ArgumentException($"El lado {side}, no es valido.");
        }
        return side;
    }

    public Square(string name, double side) : base(name)
    {
        _a = ValidateA(side);
    }

    public override double GetArea()
    {
        return _a * _a;
    }

    public override double GetPerimeter()
    {
        return 4 * _a;
    }
}
