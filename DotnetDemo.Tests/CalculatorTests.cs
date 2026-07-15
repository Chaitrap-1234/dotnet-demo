using Xunit;
using DotnetDemo;

namespace DotnetDemo.Tests;

public class CalculatorTests
{
    [Fact]
    public void Add_ShouldReturnCorrectSum()
    {
        var calculator = new Calculator();

        var result = calculator.Add(10,20);

        Assert.Equal(30,result);
    }
}
