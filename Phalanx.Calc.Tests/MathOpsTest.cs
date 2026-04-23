using Xunit;

namespace Phalanx.Calc.Tests;

public class MathOpsTest
{
    [Fact]
    public void AddPositives()
    {
        Assert.Equal(5.0, MathOps.Add(2, 3));
    }

    [Fact]
    public void AddNegatives()
    {
        Assert.Equal(-5.0, MathOps.Add(-2, -3));
    }

    [Fact]
    public void AddMixed()
    {
        Assert.Equal(1.0, MathOps.Add(-2, 3));
    }

    [Fact]
    public void SubtractPositives()
    {
        Assert.Equal(1.0, MathOps.Subtract(3, 2));
    }

    [Fact]
    public void SubtractNegatives()
    {
        Assert.Equal(1.0, MathOps.Subtract(-2, -3));
    }

    [Fact]
    public void MultiplyPositives()
    {
        Assert.Equal(6.0, MathOps.Multiply(2, 3));
    }

    [Fact]
    public void MultiplyNegatives()
    {
        Assert.Equal(-6.0, MathOps.Multiply(-2, 3));
    }

    [Fact]
    public void MultiplyZero()
    {
        Assert.Equal(0.0, MathOps.Multiply(0, 100));
    }

    [Fact]
    public void DivideBasic()
    {
        Assert.Equal(2.0, MathOps.Divide(6, 3));
    }

    [Fact]
    public void DivideNegatives()
    {
        Assert.Equal(2.0, MathOps.Divide(-6, -3));
    }

    [Fact]
    public void DivideByZeroThrows()
    {
        Assert.Throws<DivideByZeroException>(() => MathOps.Divide(1, 0));
    }

    [Fact]
    public void PercentageBasic()
    {
        Assert.Equal(12.5, MathOps.Percentage(25, 200));
    }

    [Fact]
    public void PercentageWholeZeroThrows()
    {
        Assert.Throws<DivideByZeroException>(() => MathOps.Percentage(10, 0));
    }

    [Fact]
    public void AverageNonEmpty()
    {
        Assert.Equal(4.0, MathOps.Average(new double[] { 2, 4, 6 }));
    }

    [Fact]
    public void AverageEmptyThrows()
    {
        Assert.Throws<ArgumentException>(() => MathOps.Average(new double[] { }));
    }
}
