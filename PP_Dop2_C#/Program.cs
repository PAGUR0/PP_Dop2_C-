class ComplexNumber
{
    public double Real;
    public double Imaginary;

    public ComplexNumber(double real, double imaginary)
    {
        Real = real;
        Imaginary = imaginary;
    }
    public ComplexNumber Add(ComplexNumber x)
    {
        return new ComplexNumber(Real + x.Real, Imaginary + x.Imaginary);
    }

    public ComplexNumber Subtract(ComplexNumber x)
    {
        return new ComplexNumber(Real - x.Real, Imaginary - x.Imaginary);
    }

    public ComplexNumber Multiply(ComplexNumber x)
    {
        double newReal = Real * x.Real - Imaginary * x.Imaginary;
        double newImaginary = Real * x.Imaginary + Imaginary * x.Real;
        return new ComplexNumber(newReal, newImaginary);
    }

    public ComplexNumber Divide(ComplexNumber x)
    {
        double divisor = x.Real * x.Real + x.Imaginary * x.Imaginary;
        double newReal = (Real * x.Real + Imaginary * x.Imaginary) / divisor;
        double newImaginary = (Imaginary * x.Real - Real * x.Imaginary) / divisor;
        return new ComplexNumber(newReal, newImaginary);
    }

    public string getComplexNumber()
    {
        if (Imaginary >= 0)
            return $"{Real} + {Imaginary}i";
        else
            return $"{Real} - {-Imaginary}i";
    }

}

class Program
{
    static void Main()
    {
        ComplexNumber a = new ComplexNumber(3, 2);
        ComplexNumber b = new ComplexNumber(1, -1);

        Console.WriteLine(a.Add(b).getComplexNumber());
        Console.WriteLine(a.Subtract(b).getComplexNumber());
        Console.WriteLine(a.Multiply(b).getComplexNumber());
        Console.WriteLine(a.Divide(b).getComplexNumber());
    }
}