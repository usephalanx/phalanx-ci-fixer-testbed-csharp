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
}
