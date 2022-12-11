namespace RomanNumerals;

public class Numerals
{
    private IEnumerable<Numeral> _numerals;//only expose as IEnumerable so only the constructor can add to list

    public Numerals()
    {
        Numeral one = new Numeral("I", 1);
        Numeral four = new Numeral("IV", 4);
        Numeral five = new Numeral("V", 5);
        Numeral nine = new Numeral("IX", 9);
        Numeral ten = new Numeral("X", 10);
        Numeral forty = new Numeral("XL", 40);
        Numeral fifty = new Numeral("L", 50);
        Numeral ninety = new Numeral("XC", 90);
        Numeral oneHundred = new Numeral("C", 100);
        Numeral fourHundred = new Numeral("CD", 400);
        Numeral nineHundred = new Numeral("CM", 900);
        Numeral oneThousand = new Numeral("M", 1000);
        Numeral oneThousandFiveHundred = new Numeral("MD", 1500);
        Numeral oneThousandNineHundred = new Numeral("MCM", 1900);
        

        _numerals = new List<Numeral> {oneThousandNineHundred,oneThousandFiveHundred,oneThousand,nineHundred,fourHundred,oneHundred,ninety,fifty,forty,ten,nine,five, four, one };
    }
    
    public string Convert(int number)
    {
        string resultNumeral = ""; //xx
        foreach (Numeral numeral in _numerals)
        {
            var(symbol,remainder) = Check(number, numeral); //xx 9 
            resultNumeral = resultNumeral + symbol;
            number = remainder;
        }

        return resultNumeral;
    }

    // tuple method returns numeral symbol and remainder
    private (string, int) Check (int number, Numeral numeral)
    {
        //how many of Numeral.value is in number
        // if number = 29;  29/numeral.value
        var count= number / numeral.Value; 
        //29/10= 2 count 
        var symbol = String.Concat(Enumerable.Repeat(numeral.Symbol, count));;//repeat string creates lists of X strings, each list is x then concat into one list //XX
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