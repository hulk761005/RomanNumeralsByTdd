﻿using RomanNumeralsByTdd;

namespace RomanNumeralsByTddTest;

public class RomanNumeralsConverterTest
{
    [Fact]
    public void Number_1_Convert_To_I()
    {
        var number = 1;
        var converter = new RomanNumeralsConverter();
        var result = converter.Convert(number);
        
        Assert.Equal("I", result);
    }
}