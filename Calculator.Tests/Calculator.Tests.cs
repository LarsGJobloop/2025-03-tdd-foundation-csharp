namespace Calculator.Tests;

public class Addition
{
    [Fact]
    public void TwoPlussTwoIsFour()
    {
        // Arrange
        var calculator = new Calculator();
        float a = 2;
        float b = 2;

        // Act
        var result = calculator.Add(a, b);

        // Assert
        Assert.Equal(4, result);
    }

    [Fact]
    public void WhatToDoWithOverflowOrUnderflow()
    {
        // Arrange
        var calculator = new Calculator();
        float a = float.MaxValue;
        float b = float.MaxValue;

        // Act & Assert
        Assert.Throws<ArgumentException>(() => calculator.Add(a, b));
    }
}
