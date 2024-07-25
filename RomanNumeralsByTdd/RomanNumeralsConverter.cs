using System.Text;

namespace RomanNumeralsByTdd;

public class RomanNumeralsConverter
{
    public string Convert(int number)
    {
        var sb = new StringBuilder();
        for (var i = 0; i < number; i++)
        {
            sb.Append('I');
        }

        return sb.ToString();
    }
}