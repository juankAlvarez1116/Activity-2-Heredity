namespace Backend;

public abstract class GeometricFigure
{
    // Fields



    // Constructors



    // Properties

    public string Name { get; set; } = null!;

    // Methods

    public override string ToString()
    {
        return $"{Name}\t => Area.....: {GetArea(),12:N5}\t" +
               $"Perimeter: {GetPerimeter(),12:N5}";
    }

    public abstract double GetArea();
    public abstract double GetPerimeter();
}
