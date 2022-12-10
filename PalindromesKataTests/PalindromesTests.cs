using NUnit.Framework;
using PalindromesKata;

namespace PalindromesKataTests;

public class PalindromesTests
{
    private Palindromes _palindromes;
    
    [SetUp]
    public void Setup()
    {
        //arrange
        _palindromes = new Palindromes();
    }

    [Test]
    public void when_I_pass_a_I_will_get_true()
    {
        //act 
        var actual = _palindromes.IsPalindrome("a");
        //assert 
        Assert.That(actual,Is.EqualTo(true));
    }
    
    [Test]
    public void when_I_pass_aa_I_will_get_true()
    {
        //act 
        var actual = _palindromes.IsPalindrome("aa");
        //assert 
        Assert.That(actual,Is.EqualTo(true));
    }
    
    [Test]
    public void when_I_pass_ab_I_will_get_false()
    {
        //act 
        var actual = _palindromes.IsPalindrome("ab");
        //assert 
        Assert.That(actual,Is.EqualTo(false));
    }
    
    [Test]
    public void when_I_pass_mixed_case_palindrome_I_will_get_true()
    {
        //act 
        var actual = _palindromes.IsPalindrome("Able was I ere I saw Elba");
        //assert 
        Assert.That(actual,Is.EqualTo(true));
    }
    
    [Test]
    public void when_I_pass_palindrome_containing_whitespace_and_punctuation_I_will_get_true()
    {
        //act 
        var actual = _palindromes.IsPalindrome("A man, a plan, a canal, Panama!");
        //assert 
        Assert.That(actual,Is.EqualTo(true));
    }
}
