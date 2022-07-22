using System.Collections.Generic;
using Xunit;

namespace XUnitTestUdemy.TEST;

public class AssertMethodExamples
{
    [Fact]
    public void AssertContains()
    {
        var list = new List<int> { 1, 2, 3 };
        var names = new List<string> { "John", "Paul", "George" };
        
        
        Assert.Contains(2, list);
        Assert.DoesNotContain( 4, list);
        Assert.DoesNotContain("Furkan", "Erkam Sevgili");
        Assert.DoesNotContain("Erkam",names);
        Assert.Contains("John", names);
        Assert.Contains(names, x => x == "Paul");
        Assert.DoesNotContain(names, x => x == "Ömer");
    }

    [Fact]
    public void AssertBoolean()
    {
        Assert.True(5>2);
        Assert.False(5<2);
        Assert.True("" is string);
    }

    [Fact]
    public void AssertMatch()
    {
        // Checks if regex matches the string
        Assert.Matches("[0-9]*", "123");
        
        // Checks if regex does not match the string
        Assert.DoesNotMatch("^dog", "cat");
    }
    
    [Fact]
    public void AssertStartWith()
    {
        Assert.StartsWith("Hello", "Hello World");
        Assert.EndsWith("World", "Hello World");
    }
    
    [Fact]
    public void AssertEmpty()
    {
        Assert.Empty(new List<int>());
        Assert.NotEmpty(new List<string>(){"Hello", "World", "!"});
    }
    
    [Fact]
    public void AssertInRange()
    {
        Assert.InRange(5, 1, 10);
        Assert.InRange(5, 1, 5);
        Assert.NotInRange(5, 1, 4);
    }
    
    [Fact]
    public void AssertSingle()
    {
        Assert.Single(new List<int>{1});
    }
    
    [Fact]
    public void AssertIsType()
    {
        Assert.IsType<int>(5);
        Assert.IsNotType<string>('A');
    }
    
    [Fact]
    public void AssertIsAssignableFrom()
    {
        var i = 5;
        Assert.IsAssignableFrom<int>(i);
        
        var s = "Hello";
        Assert.IsAssignableFrom<string>(s);
        
        var list = new List<int>(){1,2,3};
        Assert.IsAssignableFrom<IEnumerable<int>>(list);
    }
    
    [Fact]
    public void AssertNull()
    {
        Assert.Null(null);
        Assert.NotNull("Hello");
    }

    [Fact]
    public void AssertEqual()
    {
        Assert.Equal(5, 5);
        Assert.NotEqual(5, 4);
    }
    
    
}