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

    [Fact]
    public void Number_7_Convert_To_VII()
    {
        var number = 7;
        var converter = new RomanNumeralsConverter();
        var result = converter.Convert(number);

        result.Should().Be("VII");
    }

    [Fact]
    public void Number_8_Convert_To_VIII()
    {
        var number = 8;
        var converter = new RomanNumeralsConverter();
        var result = converter.Convert(number);

        result.Should().Be("VIII");
    }

    [Fact]
    public void Number_9_Convert_To_IX()
    {
        var number = 9;
        var converter = new RomanNumeralsConverter();
        var result = converter.Convert(number);

        result.Should().Be("IX");
    }

    [Fact]
    public void Number_10_Convert_To_X()
    {
        var number = 10;
        var converter = new RomanNumeralsConverter();
        var result = converter.Convert(number);

        result.Should().Be("X");
    }

    [Fact]
    public void Number_11_Convert_To_XI()
    {
        var number = 11;
        var converter = new RomanNumeralsConverter();
        var result = converter.Convert(number);

        result.Should().Be("XI");
    }

    [Fact]
    public void Number_12_Convert_To_XII()
    {
        var number = 12;
        var converter = new RomanNumeralsConverter();
        var result = converter.Convert(number);

        result.Should().Be("XII");
    }

    [Fact]
    public void Number_13_Convert_To_XIII()
    {
        var number = 13;
        var converter = new RomanNumeralsConverter();
        var result = converter.Convert(number);

        result.Should().Be("XIII");
    }

    [Fact]
    public void Number_14_Convert_To_XIV()
    {
        var number = 14;
        var converter = new RomanNumeralsConverter();
        var result = converter.Convert(number);

        result.Should().Be("XIV");
    }

    [Fact]
    public void Number_15_Convert_To_XV()
    {
        var number = 15;
        var converter = new RomanNumeralsConverter();
        var result = converter.Convert(number);

        result.Should().Be("XV");
    }

    [Fact]
    public void Number_16_Convert_To_XVI()
    {
        var number = 16;
        var converter = new RomanNumeralsConverter();
        var result = converter.Convert(number);

        result.Should().Be("XVI");
    }

    [Fact]
    public void Number_19_Convert_To_XIX()
    {
        var number = 19;
        var converter = new RomanNumeralsConverter();
        var result = converter.Convert(number);

        result.Should().Be("XIX");
    }

    [Fact]
    public void Number_20_Convert_To_XX()
    {
        var number = 20;
        var converter = new RomanNumeralsConverter();
        var result = converter.Convert(number);

        result.Should().Be("XX");
    }
}