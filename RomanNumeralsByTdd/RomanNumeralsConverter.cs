using System.Text;

namespace RomanNumeralsByTdd;

public class RomanNumeralsConverter
{
    private readonly IEnumerable<char> RomanNumerals = new List<char> { 'X', 'V', 'I' };
    public string Convert(int number)
    {
        var sb = new StringBuilder();
        while (number > 0)
        {
            switch (number)
            {
                case >= 10:
                    sb.Append('X');
                    number -= 10;
                    break;
                case 9:
                    sb.Append("IX");
                    number -= 9;
                    break;
                case >= 5:
                    sb.Append('V');
                    number -= 5;
                    break;
                case 4:
                    sb.Append("IV");
                    number -= 4;
                    break;
                default:
                    sb.Append('I');
                    number -= 1;
                    break;
            }
        }

        return sb.ToString();
    }
}