
namespace StringCalculator;

public class StringCalculatorTests
{
    [Fact]
    public void EmptyStringReturnsZero()
    {
        var calculator = new StringCalculator();

        var result = calculator.Add("");

        Assert.Equal(0, result);
    }
    [Theory]
    [InlineData("1", 1)]
    [InlineData("12", 12)]
    [InlineData("108", 108)]
    public void SingleDigits(string numbers, int expected)
    {
        var calculator = new StringCalculator();

        var result = calculator.Add(numbers);

        Assert.Equal(expected, result);
    }
    [Theory]
    [InlineData("1,2", 3)]
    [InlineData("108,2", 110)]
    [InlineData("10,50", 60)]
    public void TwoDigits(string numbers, int expected)
    {
        var calculator = new StringCalculator();

        var result = calculator.Add(numbers);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("1,2,3", 6)]
    [InlineData("1,2,3,4,5,6,7,8,9", 45)]
    [InlineData("108,2,20", 130)]
    public void ArbitraryNumbers(string numbers, int expected)
    {
        var calculator = new StringCalculator();

        var result = calculator.Add(numbers);

        Assert.Equal(expected, result);
    }
    [Theory]
    [InlineData("1,2\n3", 6)]
    [InlineData("1\n2", 3)]
    public void MixedDelimeters(string numbers, int expected)
    {
        var calculator = new StringCalculator();

        var result = calculator.Add(numbers);

        Assert.Equal(expected, result);
    }
    [Theory]
    [InlineData("//;\n1;2", 3)]
    [InlineData("//;\n3;3", 6)]
    [InlineData("//;\n1,2,3;4", 10)]

    public void CustomDelimeters(string numbers, int expected)
    {
        var calculator = new StringCalculator();

        var result = calculator.Add(numbers);

        Assert.Equal(expected, result);
    }
    [Theory]
    [InlineData("-1")]
    [InlineData("1,-1")]
    public void NegativeNumbersThrows(string numbers)
    {
        var calculator = new StringCalculator();

        Assert.Throws<NoNegativeNumbersException>(() =>
        {
            calculator.Add(numbers);
        });
    }

    [Fact(Skip = "Do this later")]
    public void WhatIfTHeyPassInANonNumber()
    {
        var calculator = new StringCalculator();

        calculator.Add("1,DOG");

    }
}
