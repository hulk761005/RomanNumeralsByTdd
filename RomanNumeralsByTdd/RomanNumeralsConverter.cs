using System.Text;

namespace RomanNumeralsByTdd;

public class RomanNumeralsConverter
{
    private readonly IEnumerable<char> RomanNumerals = new List<char> { 'X', 'V', 'I' };
    public string Convert(int number)
    {
        var remainder = 0; 
        var quotient = 0;
        var sb = new StringBuilder();


        while (number >= 10)
        {
            sb.Append('X');
            number -= 10;
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
                while (remainder >= 1)
                {
                    sb.Append('I');
                    remainder -= 1;
                }
            }
        }

        return sb.ToString();
    }
}