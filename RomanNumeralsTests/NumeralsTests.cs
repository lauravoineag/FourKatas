using NUnit.Framework;
using RomanNumerals;

namespace RomanNumeralsTests;

public class NumeralsTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void when_I_convert_number_1_I_will_get_numeral_I()
    {
        //arange
        var numerals = new Numerals();
        //act
        var actual = numerals.Convert(1); 
        //assert
        Assert.That(actual,Is.EqualTo("I"));
    }
    
    [Test]
    public void when_I_convert_number_2_I_will_get_numeral_II()
    {
        //arange
        var numerals = new Numerals();
        //act
        var actual = numerals.Convert(2); 
        //assert
        Assert.That(actual,Is.EqualTo("II"));
    }
}
