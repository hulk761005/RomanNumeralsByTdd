using System.Text;

namespace RomanNumeralsByTdd;

public class RomanNumeralsConverter
{
    private readonly Dictionary<int, string> RomanNumeralsDictionary = new()
    {
        { 4, "IV" },
        { 5, "V" }
    };
    public string Convert(int number)
    {
        var remainder = number % 5; 
        var quotient = number / 5;
        var sb = new StringBuilder();
        if (quotient > 0)
        {
            sb.Append('V');
        }

        if (remainder == 4)
        {
            return "IV";
        }

        for (var i = 0; i < remainder; i++)
        {
            sb.Append('I');
        }

        return sb.ToString();
    }
}