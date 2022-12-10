namespace RomanNumerals;

public class Numerals
{
    public string Convert(int number)
    {
        if (number == 4)
        {
            return "IV";
        }
        return new string('I', number);
    }
}