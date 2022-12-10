using NUnit.Framework;

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
}