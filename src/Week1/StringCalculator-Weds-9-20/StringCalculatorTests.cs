
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

    [Fact]
    public void SingleNumberReturnsItself()
    {
        var calculator = new StringCalculator();
        var result = calculator.Add("1");
        Assert.Equal(1, result);
    }

    [Fact]
    public void TwoNumbersSeparatedByComma()
    {
        var calculator = new StringCalculator();
        var result = calculator.Add("1,2");
        Assert.Equal(3, result);
    }
}
