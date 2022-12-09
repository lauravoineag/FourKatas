namespace PalindromesKata;

public class Palindromes
{
    public bool IsPalindrome(string input)
    {
        var reversedChar = input.Reverse().ToArray(); //string is IEnumerable of char
        var reversed = new String(reversedChar); //converting Ienumerable of char into string.
        if (input ==reversed)
        {
            return true;
        }
        return false;
    }
}

    

