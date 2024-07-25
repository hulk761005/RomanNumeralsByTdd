using System.Text;

namespace RomanNumeralsByTdd;

public class RomanNumeralsConverter
{
    private readonly Dictionary<int, string> RomanNumeralsDictionary = new()
    {
        { 4, "IV" },
        { 2, "V" }
    };
    public string Convert(int number)
    {
        var remainder = 0; 
        var quotient = 0;
        var sb = new StringBuilder();
        if (number >= 10)
        {
            quotient = number / 10;
            if (quotient > 0)
            {
                sb.Append('X');
                number -= 10;
            }
        }

        if (number == 9)
        {
            sb.Append("IX");
        }
        else
        {
            remainder = number % 5; 
            quotient = number / 5;
        
            if (quotient > 0)
            {
                sb.Append('V');
            }

            if (remainder == 4)
            {
                sb.Append("IV");
            }
            else
            {
                for (var i = 0; i < remainder; i++)
                {
                    sb.Append('I');
                }
            }
        }

        return sb.ToString();
    }
}