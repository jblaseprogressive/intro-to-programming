
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

    [Fact]
    public void SingleNumberWithoutComma()
    {
        var calculator = new StringCalculator();
        var result = calculator.Add("5");
        Assert.Equal(5, result);
    }

    [Fact]
    public void NewLinesSeperator()
    {
        var calculator = new StringCalculator();
        var result = calculator.Add("1\n2, 3");
        Assert.Equal(6, result);
    }
}
