using FluentAssertions;
using RomanNumeralsByTdd;

namespace RomanNumeralsByTddTest;

public class RomanNumeralsConverterTest
{
    [Fact]
    public void Number_1_Convert_To_I()
    {
        var number = 1;
        var converter = new RomanNumeralsConverter();
        var result = converter.Convert(number);
        
        result.Should().Be("I");
    }

    [Fact]
    public void Number_2_Convert_To_II()
    {
        var number = 2;
        var converter = new RomanNumeralsConverter();
        var result = converter.Convert(number);
        
        result.Should().Be("II");
    }

    [Fact]
    public void Number_3_Convert_To_III()
    {
        var number = 3;
        var converter = new RomanNumeralsConverter();
        var result = converter.Convert(number);
        
        result.Should().Be("III");
    }
    
    [Fact]
    public void Number_4_Convert_To_IV()
    {
        var number = 4;
        var converter = new RomanNumeralsConverter();
        var result = converter.Convert(number);
        
        result.Should().Be("IV");
    }
    
    [Fact]
    public void Number_5_Convert_To_V()
    {
        var number = 5;
        var converter = new RomanNumeralsConverter();
        var result = converter.Convert(number);

        result.Should().Be("V");
    }
    
    [Fact]
    public void Number_6_Convert_To_VI()
    {
        var number = 6;
        var converter = new RomanNumeralsConverter();
        var result = converter.Convert(number);

        result.Should().Be("VI");
    }
}