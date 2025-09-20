namespace Objetos.Class;

public class Calculator
{
    public int sum(int a, int b, string c)
    {
        return a + b;
    }

    public int rest(int a, int b, string c)
    {
        return a - b;
    }

    public int multiply(int a, int b, string c)
    {
        return a * b;
    }

    public decimal divide(int a, int b, string c)
    {
        return (decimal)a / b;
    }
}