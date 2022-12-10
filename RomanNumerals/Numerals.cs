namespace RomanNumerals;

public class Numerals
{
    private IEnumerable<Numeral> _numerals;//only expose as IEnumerable so only the constructor can add to list

    public string Convert(int number)
    {
        foreach (Numeral numeral in _numerals)
        {
            if (numeral.Value == number)
            {
                return numeral.Symbol;
            }
        }
        throw new ArgumentOutOfRangeException(nameof(number));
    }

    public Numerals()
    {
        Numeral one = new Numeral("I", 1);
        Numeral two = new Numeral("II", 2);
        Numeral three = new Numeral("III", 3);
        Numeral four = new Numeral("IV", 4);
        Numeral five = new Numeral("V", 5);
        _numerals = new List<Numeral> {five, four, three, two, one };
    }
}

public class Numeral // data class
{
    public string Symbol { get; set; }
    public int Value { get; set; }
    public Numeral(string symbol, int value)
    {
        Symbol = symbol;
        Value = value;
    }
}