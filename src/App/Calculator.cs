namespace App;
public static class Calculator
{
    public static int Value1 => 5;
    public static int Value2 => 5;

    public static int Sum()
    {
        return Value1 + Value2;
    }

    public static int Subtraction()
    {
        return Value1 - Value2;
    }

    public static int Division()
    {
        return Value1 / Value2;
    }

    public static int Multiplication()
    {
        return Value1 * Value2;
    }
}