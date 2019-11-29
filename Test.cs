using Xunit;
using System;
using Plexus;

public class Tests
{
    [Fact]
    public void TestAdd()
    {
        var calculator = new Program();
        Assert.Equal(5, calculator.add(1, 4));
    }

    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(-4, -6, -10)]
    [InlineData(-2, 2, 0)]
    [InlineData(int.MinValue, -1, int.MaxValue)]
    public void CanAddTheory(int value1, int value2, int expected)
    {
        var calculator = new Program();
        var result = calculator.add(value1, value2);
        Assert.Equal(expected, result);
    }
}