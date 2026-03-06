namespace Backend;

public class Circle : GeometricFigure
{
    // Fields

    private double _r;

    // Constructors

    public Circle(string name, double r)
    {
        Name = name;
        R = r;
    }

    // Properties

    public double R 
    { 
        get => _r; 
        set => _r = ValidateR(value); 
    }

    // Methods
    public override double GetArea() => double.Pi * (R * R);

    public override double GetPerimeter() => 2 * double.Pi * R;

    private double ValidateR(double r)
    {
        if (r <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(r), "r must be greater than 0");
        }
        return r;
    }
}