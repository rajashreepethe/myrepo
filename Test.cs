using Xunit;
using System;
using Plexus;

public class Tests
{
    [Fact]
    public void TestAdd()
    {
        var calculator = new WaterCalculator();
        calculator.CalculateWaterInGlass(0,0,250);
        Assert.Equal("250.00", calculator.WaterInGlass.ToString("n2"));
    }

    [Theory]
    [InlineData(0, 0, 1000, "250.00")]
    [InlineData(0, 0, 19, "19.00")]
    [InlineData(1, 0, 500, "125.00")]
    [InlineData(2, 0, 1002, "84.00")]
    [InlineData(2, 1, 500, "0.00")]
    [InlineData(0, 0, 125.8, "125.80")]
    [InlineData(2, 0, 1125.8, "125.27")]
    
    public void CanAddTheory(int row, int glass, double totalWater, string expected)
    {
        var calculator = new WaterCalculator();
        calculator.CalculateWaterInGlass(row,glass,totalWater);
        Assert.Equal(expected, calculator.WaterInGlass.ToString("n2"));
    }
}