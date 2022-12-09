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
        var actual = palindromes.Execute("a");
        //assert 
        Assert.That(actual,Is.EqualTo(true));
    }
}