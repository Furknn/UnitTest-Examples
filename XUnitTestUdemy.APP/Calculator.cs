namespace XUnitTestUdemy.APP;

public class Calculator
{
    public Calculator(ICalculatorService calculatorService)
    {
        _calculatorService = calculatorService;
    }

    private ICalculatorService _calculatorService { get; set; }
    public int Add(int a, int b)
    {
        return _calculatorService.Add(a, b);
    }
    
    public int Multiply(int a, int b)
    {
        return _calculatorService.Multiply(a, b);
    }
}