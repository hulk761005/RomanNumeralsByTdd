using System.Text;

namespace RomanNumeralsByTdd;

public class RomanNumeralsConverter
{
    private static readonly (int Value, string Numeral)[] RomanNumerals = 
    {
        (1000, "M"), (900, "CM"), (500, "D"), (400, "CD"),
        (100, "C"), (90, "XC"), (50, "L"), (40, "XL"),
        (10, "X"), (9, "IX"), (5, "V"), (4, "IV"),
        (1, "I")
    };

    public string Convert(int number)
    {
        var sb = new StringBuilder();
        
        foreach (var (value, numeral) in RomanNumerals)
        {
            while (number >= value)
            {
                sb.Append(numeral);
                number -= value;
            }
        }

        return sb.ToString();
    }
}