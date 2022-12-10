namespace PalindromesKata;

public class Palindromes
{
    public bool IsPalindrome(string input)
    {
        //filtering punctuation characters out of the string.
        var newInput = new string(input.Where(c => !char.IsPunctuation(c)&& !char.IsWhiteSpace(c)).ToArray());
        var reversedChar = newInput.Reverse().ToArray(); //string is IEnumerable of char // String constructor needs an Array
        var reversed = new String(reversedChar); //converting IEnumerable of char into string.
        if (string.Equals(newInput, reversed, StringComparison.CurrentCultureIgnoreCase)) //check case sensitive
        {
            return true;
        }

        return false;
    }
}