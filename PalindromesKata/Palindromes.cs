namespace PalindromesKata;

public class Palindromes
{
    public bool IsPalindrome(string input)
    {
        //strip whitespace and punctuation
        
        var reversedChar = input.Reverse().ToArray(); //string is IEnumerable of char // String constructor needs an Array
        var reversed = new String(reversedChar); //converting IEnumerable of char into string.
        if  (string.Equals(input,reversed,StringComparison.CurrentCultureIgnoreCase))//check case sensitive
        {
            return true;
        }
        return false;
    }
}

    

