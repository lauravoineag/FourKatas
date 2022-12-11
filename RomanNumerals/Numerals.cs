namespace RomanNumerals;

public class Numerals
{
    private IEnumerable<Numeral> _numerals;//only expose as IEnumerable so only the constructor can add to list

    public Numerals()
    {
        Numeral one = new Numeral("I", 1);
        Numeral four = new Numeral("IV", 4);
        Numeral five = new Numeral("V", 5);
        _numerals = new List<Numeral> {five, four, one };
    }
    
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

    // tuple method returns numeral symbol and remainder
    private (string, int) Check (int number, Numeral numeral)
    {
        //how many of Numeral.value is in number
        // if 29/numeral.value
        var count= number / numeral.Value; 
        //29/10= 2 count 
        var symbol = String.Concat(Enumerable.Repeat(numeral.Symbol, count));;//repeat string and creates a list, each string is x then concat //XX
        //what's left  
        var remainder = number % numeral.Value; // 9
        return (symbol, remainder);
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