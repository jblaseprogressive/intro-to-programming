using Xunit;

namespace StringCalculator
{
    public class StringCalculatorTests
    {
        [Theory]
        [InlineData("", 0)] // Empty string returns zero
        [InlineData("1", 1)] // Single number returns itself
        [InlineData("1,2", 3)] // Two numbers separated by a comma
        [InlineData("5", 5)] // Single number without a comma
        [InlineData("1\n2,3", 6)] // New lines between numbers
        [InlineData("//;\n1;2;3", 6)] // Custom delimiter using ';'
        [InlineData("//$\n4$5$6", 15)] // Custom delimiter using '$'
        [InlineData("//*\n7*8*9", 24)] // Custom delimiter using '*'
        [InlineData("//|\n4|5|6", 15)] // Custom delimiter using '|'
        [InlineData("//@\n7@8@9", 24)] // Custom delimiter using '@'
        [InlineData("//%\n10%11%12", 33)] // Custom delimiter using '%'
        [InlineData("1,2,3,4,5,6,7,8,9,10,11,12,13,14,15", 120)] // 15 numbers separated by commas
        [InlineData("1\n2\n3\n4\n5\n6\n7\n8\n9\n10\n11\n12\n13\n14\n15", 120)] // 15 numbers separated by new lines
        [InlineData("//;\n1;2;3;4;5;6;7;8;9;10;11;12;13;14;15", 120)] // 15 numbers separated by custom delimiter ';'
        public void AddHandlesDifferentInputs(string input, int expected)
        {
            var calculator = new StringCalculator();
            var result = calculator.Add(input);
            Assert.Equal(expected, result);
        }
    }
}
