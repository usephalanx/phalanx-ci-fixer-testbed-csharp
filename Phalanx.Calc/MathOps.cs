namespace Phalanx.Calc;

// Basic arithmetic helpers — C# testbed mirror of the Python/TS/JS/Java
// math_ops. The 4 failure patches under ../failures/ mutate this file
// (or tests) to exercise each scorecard cell.
public static class MathOps
{
    public static double Add(double a, double b) => a + b;

    public static double Subtract(double a, double b) => a - b;

    public static double Multiply(double a, double b) => a * b;

    public static double Divide(double a, double b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("cannot divide by zero");
        }
        return a / b;
    }

    public static double Percentage(double part, double whole)
    {
        if (whole == 0)
        {
            throw new DivideByZeroException("cannot compute percentage of zero");
        }
        return (part / whole) * 100;
    }

    public static double Average(double[] values)
    {
        if (values.Length == 0)
        {
            throw new ArgumentException("cannot average an empty list");
        }
        double sum = 0;
        foreach (double v in values) { sum += v; }
        return sum / values.Length;
    }
}
