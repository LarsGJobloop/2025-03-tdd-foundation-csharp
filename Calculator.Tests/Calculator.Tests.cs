using Logger;
using Moq;

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
    public void OverflowThrowsAnException()
    {
        // Arrange
        var calculator = new Calculator();
        float a = float.MaxValue;
        float b = float.MaxValue;

        // Act & Assert
        Assert.Throws<ArgumentException>(() => calculator.Add(a, b));
    }
}

public class LoggingCalculator
{
    [Fact]
    public void AdditionLogsOperation()
    {
        // Arrange
        var logger = new Mock<ICustomLogger>();
        // We need a reference to the logger instance which we pass in to
        // the Calculator constructor
        var calculator = new Calculator(logger.Object);
        float a = 10;
        float b = 10;
        string logMessage = $"Added {a} and {b}";

        // Act
        calculator.Add(a, b);

        // Assert
        logger.Verify(l => l.Log(logMessage), Times.Once);
    }
}