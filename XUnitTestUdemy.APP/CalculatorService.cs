namespace XUnitTestUdemy.APP;

public class CalculatorService : ICalculatorService
{
    public int Add(int a, int b)
    {
        if (a == 0 || b == 0)
        {
            return 0;
        }

        return a + b;
    }

    public int Multiply(int a, int b)
    {
        if (a == 0)
        {
            throw new Exception("a=0 olamaz");
        }

        return a * b;
    }
}

public interface ICalculatorService
{
    public int Add(int a, int b);
    public int Multiply(int a, int b);
}