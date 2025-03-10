using System;

using Geometry;

public class Rectangle : Square
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

    public Rectangle(string name, double side1, double side2) : base(name, side1)
    {
        _b = ValidateB(side2);
    }

    public override double GetArea()
    {
        return A * _b;
    }

    public override double GetPerimeter()
    {
        return 2 * (A + B);
    }
}