using System;

namespace Geometry
{
    public abstract class GeometricFigure
    {
        public string Name { get; }

        protected GeometricFigure(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("El nombre no puede estar vacío.");
            Name = name;
        }

        public abstract double GetArea();
        public abstract double GetPerimeter();

        public override string ToString()
        {
            return string.Format("{0,-14} = > Area......: {1,12:F5} Perimeter: {2,12:F5}", Name, GetArea(), GetPerimeter());
        }
    }
}