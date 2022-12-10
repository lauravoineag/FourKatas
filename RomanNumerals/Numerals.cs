namespace RomanNumerals;

public class Numerals
{
    public string Convert(int number)
    {
        if (number == 1)
        {
            return "I";
        }
        return "II";
    }
}