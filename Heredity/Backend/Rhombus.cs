namespace Backend;

public class Rhombus : Square
{
    // Fields

    private double _d1;
    private double _d2;

    // Constructors

    public Rhombus(string name, double a, double d1, double d2) : base(name, a)
    {
        D1 = d1;
        D2 = d2;
    }

    // Properties

    public double D1 
    { 
        get => _d1; 
        set => _d1 = ValidateD1(value); 
    }
    public double D2 
    { 
        get => _d2; 
        set => _d2 = ValidateD2(value); 
    }

    // Methods

    public override double GetArea() => (D1 * D2) / 2;

    public override double GetPerimeter() => 4 * A;

    private double ValidateD1(double d1)
    {
        if (d1 <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(d1), "d1 must be greater than 0");
        }
        return d1;
    }

    private double ValidateD2(double d2)
    {
        if (d2 <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(d2), "d2 must be greater than 0");
        }
        return d2;
    }
}
