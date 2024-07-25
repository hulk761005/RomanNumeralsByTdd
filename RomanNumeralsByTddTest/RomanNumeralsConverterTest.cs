using FluentAssertions;
using RomanNumeralsByTdd;

namespace RomanNumeralsByTddTest;

public class RomanNumeralsConverterTest
{
    [Theory]
    [InlineData(1, "I")]
    [InlineData(2, "II")]
    [InlineData(3, "III")]
    [InlineData(4, "IV")]
    [InlineData(5, "V")]
    [InlineData(6, "VI")]
    [InlineData(7, "VII")]
    [InlineData(8, "VIII")]
    [InlineData(9, "IX")]
    [InlineData(10, "X")]
    [InlineData(11, "XI")]
    [InlineData(12, "XII")]
    [InlineData(13, "XIII")]
    [InlineData(14, "XIV")]
    [InlineData(15, "XV")]
    [InlineData(16, "XVI")]
    [InlineData(19, "XIX")]
    [InlineData(20, "XX")]
    [InlineData(21, "XXI")]
    [InlineData(22, "XXII")]
    [InlineData(24, "XXIV")]
    [InlineData(25, "XXV")]
    [InlineData(28, "XXVIII")]
    [InlineData(29, "XXIX")]
    [InlineData(30, "XXX")]
    [InlineData(32, "XXXII")]
    [InlineData(39, "XXXIX")]
    [InlineData(40, "XL")]
    [InlineData(41, "XLI")]
    [InlineData(42, "XLII")]
    [InlineData(43, "XLIII")]
    [InlineData(44, "XLIV")]
    [InlineData(45, "XLV")]
    [InlineData(46, "XLVI")]
    [InlineData(47, "XLVII")]
    [InlineData(48, "XLVIII")]
    [InlineData(49, "XLIX")]
    [InlineData(50, "L")]
    public void Number_Convert_To_RomanNumerals(int number, string expect)
    {
        var converter = new RomanNumeralsConverter();
        var result = converter.Convert(number);
        result.Should().Be(expect);
    }
}