using Xunit;
using XUnitTestUdemy.APP;

namespace XUnitTestUdemy.TEST;

public class CalculatorTest
{
    private Calculator _calculator { get; set; }
    public CalculatorTest()
    {
        _calculator = new Calculator();
    }

    [Fact]
    public void Add_simpleValues_ReturnTotalValue()
    {
        // Arrange
        var a = 5;
        var b = 20;
        
        // Act
        var result = _calculator.Add(a, b);
        
        // Assert
        Assert.Equal(25, result);
    }
    
    [Theory]
    [InlineData(0,5,0)]
    [InlineData(10,2,12)]
    public void Add_zeroValues_ReturnTotalValue(int a, int b, int expectedTotal)
    {
        var actualTotal = _calculator.Add(a, b);
        Assert.Equal(actualTotal, expectedTotal);
    }
}