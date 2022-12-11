using RomanNumerals;

Console.WriteLine("Enter a number to receive a roman numeral"); 
var input=Console.ReadLine();
bool isInteger = Int32.TryParse(input,out int number);
if (isInteger == false)
{
    Console.WriteLine("You need to type a whole number");
    return; 
}
var numeral=new Numerals();
var symbol= numeral.Convert(number);
Console.WriteLine(symbol);