using PalindromesKata;

Console.WriteLine("Type a string and I'll tell you if it's a palindrome");

var input = Console.ReadLine();
var palindrome = new Palindromes();
var result = palindrome.IsPalindrome(input);

var answer = result ? "Yay it's a palindrome!" : "Tough luck it's not a palindrome :(";
Console.WriteLine(answer);