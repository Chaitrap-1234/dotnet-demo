using Xunit;

namespace DotnetDemo.Tests;

public class CalculatorTests
{
    [Fact]
    public void Add_ShouldReturnSum()
    {
        var calculator = new Calculator();

        var result = calculator.Add(2, 3);

        Assert.Equal(5, result);
    }
}
