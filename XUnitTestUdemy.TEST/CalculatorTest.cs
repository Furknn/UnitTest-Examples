using Moq;
using Xunit;
using XUnitTestUdemy.APP;

namespace XUnitTestUdemy.TEST;

public class CalculatorTest
{
    private Calculator _calculator { get; set; }
    private Mock<ICalculatorService> mymock { get; set; }
    public CalculatorTest()
    {
        mymock = new Mock<ICalculatorService>();
        _calculator = new Calculator(mymock.Object);
    }

    [Theory]
    [InlineData(5,20,25)]
    [InlineData(10,2,12)]
    public void Add_simpleValues_ReturnTotalValue(int a,int b,int expectedTotal)
    {
        
        mymock.Setup(x => x.Add(a, b)).Returns(expectedTotal);
        var actualTotal = _calculator.Add(a, b);
        
        // Assert
        Assert.Equal(expectedTotal, actualTotal);
    }
    
    [Theory]
    [InlineData(0,5,0)]
    [InlineData(10,0,0)]
    public void Add_zeroValues_ReturnTotalValue(int a, int b, int expectedTotal)
    {
        mymock.Setup(x => x.Add(a, b)).Returns(expectedTotal);
        var actualTotal = _calculator.Add(a, b);
        Assert.Equal(actualTotal, expectedTotal);
    }
    
    [Theory]
    [InlineData(5,20,120)]
    [InlineData(10,2,20)]
    public void Multiply_simpleValues_ReturnTotalValue(int a,int b,int expectedTotal)
    {
        mymock.Setup(x => x.Multiply(a, b)).Returns(expectedTotal);
        var actualMult = _calculator.Multiply(a, b);
        Assert.Equal(actualMult, expectedTotal);
    }
}