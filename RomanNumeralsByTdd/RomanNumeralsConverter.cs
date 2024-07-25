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
        var sb = new StringBuilder();
        if (number > 3)
        {
            return RomanNumeralsDictionary[number];
        }

        for (var i = 0; i < number; i++)
        {
            sb.Append('I');
        }

        return sb.ToString();
    }
}