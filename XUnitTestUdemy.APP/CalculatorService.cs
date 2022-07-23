namespace XUnitTestUdemy.APP;

public class CalculatorService:ICalculatorService
{
    public int Add(int a, int b)
    {
        //  if (a==0 || b==0)
        //  {
        //      return 0;
        //  }
        //  
        //  return a + b;
        return 0;
    }

    public int Multiply(int a, int b)
    {
        return 5;
    }
}

public interface ICalculatorService
{
    public int Add(int a, int b);
    public int Multiply(int a, int b);
}