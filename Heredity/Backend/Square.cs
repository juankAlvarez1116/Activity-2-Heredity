namespace Backend;

public class Square : GeometricFigure
{
    // Fields

    private double _a;

    // Constructors

    public Square(string name, double a)
    {
        Name = name;
        A = a;
    }

    // Properties

    public double A
    {
        get => _a;
        set => _a = ValidateA(value);
    }

    // Method
    public override double GetArea() => A * A;

    public override double GetPerimeter() => A * 4;

    private double ValidateA(double a)
    {
        if (a <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(a), "a must be greater than 0");
        }
        return a;
    }
}
