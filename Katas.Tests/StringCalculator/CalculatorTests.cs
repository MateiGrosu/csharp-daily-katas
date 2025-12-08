using Xunit;
using Katas.StringCalculator;

namespace Katas.Tests.StringCalculator;

public class CalculatorTests
{
    [Fact]
    public void Add_EmptyString_ReturnsZero()
    {
        // Arrange
        var calculator = new Calculator();

        // Act
        var result = calculator.Add("");

        // Assert
        Assert.Equal(0, result);
    }
}
