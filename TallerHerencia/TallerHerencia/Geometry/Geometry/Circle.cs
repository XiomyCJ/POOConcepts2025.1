using System;

using Geometry;

public class Circle : GeometricFigure
{
    private double _r;

    public double R
    {
        get => _r;
        set => _r = ValidateR(value);
    }
    private double ValidateR(double radius)
    {
        if (radius < 0)
        {
            throw new ArgumentException($"El radio {radius}, no es valido.");
        }
        return radius;
    }

    public Circle(string name, double radius) : base(name)
    {
        if (radius <= 0)
            throw new ArgumentException("El radio debe ser mayor que cero.");

        _r = radius;
    }

    public override double GetArea()
    {
        return Math.PI * Math.Pow(_r, 2);
    }

    public override double GetPerimeter()
    {
        return 2 * Math.PI * _r;
    }
}
