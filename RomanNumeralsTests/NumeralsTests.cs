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
    [Test]
    public void when_I_convert_number_3_I_will_get_numeral_III()
    {
        //arange
        var numerals = new Numerals();
        //act
        var actual = numerals.Convert(3); 
        //assert
        Assert.That(actual,Is.EqualTo("III"));
    }
    
    [Test]
    public void when_I_convert_number_4_I_will_get_numeral_IV()
    {
        //arange
        var numerals = new Numerals();
        //act
        var actual = numerals.Convert(4); 
        //assert
        Assert.That(actual,Is.EqualTo("IV"));
    }
    
    [Test]
    public void when_I_convert_number_5_I_will_get_numeral_V()
    {
        //arange
        var numerals = new Numerals();
        //act
        var actual = numerals.Convert(5); 
        //assert
        Assert.That(actual,Is.EqualTo("V"));
    }
    
    [Test]
    public void when_I_convert_number_9_I_will_get_numeral_IX()
    {
        //arange
        var numerals = new Numerals();
        //act
        var actual = numerals.Convert(9); 
        //assert
        Assert.That(actual,Is.EqualTo("IX"));
    }
    
    [Test]
    public void when_I_convert_number_29_I_will_get_numeral_XXIX()
    {
        //arange
        var numerals = new Numerals();
        //act
        var actual = numerals.Convert(29); 
        //assert
        Assert.That(actual,Is.EqualTo("XXIX"));
    }
    
    [Test]
    public void when_I_convert_number_49_I_will_get_numeral_XLIX()
    {
        //arange
        var numerals = new Numerals();
        //act
        var actual = numerals.Convert(49); 
        //assert
        Assert.That(actual,Is.EqualTo("XLIX"));
    }
    [Test]
    public void when_I_convert_number_95_I_will_get_numeral_XCV()
    {
        //arange
        var numerals = new Numerals();
        //act
        var actual = numerals.Convert(95); 
        //assert
        Assert.That(actual,Is.EqualTo("XCV"));
    }
}
