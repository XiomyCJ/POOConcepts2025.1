using System;

using Geometry;

public class Triangle : Rectangle
{
    private double _d;
    private double _c;

    public double H
    {
        get => _d;
        set => _d = ValidateH(value);
    }
    private double ValidateH(double height)
    {
        if (height < 0)
        {
            throw new ArgumentException($"la altura {height}, no es valida.");
        }
        return height;
    }

    public double C
    {
        get => _c;
        set => _c = ValidateC(value);
    }
    private double ValidateC(double side)
    {
        if (side < 0)
        {
            throw new ArgumentException($"El lado {side}, no es valido.");
        }
        return side;
    }
    public Triangle  (string name, double side1, double side2, double side3, double height) : base(name, side1, side2)
    {
        _c = ValidateC(side3);
        _d = ValidateH(height);
    }

    public override double GetArea()
    {
        return B * _d / 2;
    }

    public override double GetPerimeter()
    {
        return A + B + C;
    }
}