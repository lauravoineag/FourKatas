using NUnit.Framework;
using PalindromesKata;

namespace PalindromesKataTests;

public class PalindromesTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void when_I_pass_a_I_will_get_true()
    {
        //arrange
        var palindromes = new Palindromes();
        //act 
        var actual = palindromes.IsPalindrome("a");
        //assert 
        Assert.That(actual,Is.EqualTo(true));
    }
    
    [Test]
    public void when_I_pass_aa_I_will_get_true()
    {
        //arrange
        var palindromes = new Palindromes();
        //act 
        var actual = palindromes.IsPalindrome("aa");
        //assert 
        Assert.That(actual,Is.EqualTo(true));
    }
    
    [Test]
    public void when_I_pass_ab_I_will_get_false()
    {
        //arrange
        var palindromes = new Palindromes();
        //act 
        var actual = palindromes.IsPalindrome("ab");
        //assert 
        Assert.That(actual,Is.EqualTo(false));
    }
}