namespace App.Tests;
public class TCalculator
{
    [Fact]
    public void Sum()
    {
        Assert.Equal(10, Calculator.Sum());
    }

    [Fact]
    public void Subtraction()
    {
        Assert.Equal(0, Calculator.Subtraction());
    }

    [Fact]
    public void Division()
    {
        Assert.Equal(1, Calculator.Division());
    }

    [Fact]
    public void Multiplication()
    {
        Assert.Equal(25, Calculator.Multiplication());
    }
}