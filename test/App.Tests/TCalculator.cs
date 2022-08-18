namespace App.Tests;
public class TCalculator
{
    [Fact(DisplayName = "Sum Test")]
    public void Sum()
    {
        Assert.Equal(10, Calculator.Sum());
    }

    [Fact(DisplayName = "Subtraction Test")]
    public void Subtraction()
    {
        Assert.Equal(0, Calculator.Subtraction());
    }

    [Fact(DisplayName = "Division Test")]
    public void Division()
    {
        Assert.Equal(1, Calculator.Division());
    }

    [Fact(DisplayName = "Multiplication Test")]
    public void Multiplication()
    {
        Assert.Equal(25, Calculator.Multiplication());
    }
}