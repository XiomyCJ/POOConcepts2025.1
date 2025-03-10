using System;

using Geometry;

public class Parallelogram : Rectangle
{
    private double _h;

    public double H
    {
        get => _h;
        set => _h = ValidateH(value);
    }
    private double ValidateH(double height)
    {
        if (height < 0)
        {
            throw new ArgumentException($"la altura {height}, no es valida.");
        }
        return height;
    }

    public Parallelogram(string name, double side1, double side2, double height) : base(name, side1, side2)
    {
        _h = ValidateH(height);
    }

    public override double GetArea()
    {
        return B * _h;
    }

    public override double GetPerimeter()
    {
        return 2 * (A + B);
    }
}