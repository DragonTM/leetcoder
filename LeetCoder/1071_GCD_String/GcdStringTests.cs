namespace LeetCoder._1071_GCD_String;

[TestFixture]
public class GcdStringTests
{
    [TestCase("ABCABC", "ABC", "ABC")]
    [TestCase("ABABAB", "ABAB", "AB")]
    [TestCase("LEET", "CODE", "")]
    [TestCase("ABCDEF", "ABC", "")]
    [TestCase("ABABCCABAB", "ABAB", "")]
    public void TestGcd(string str1, string str2, string result)
    {
        var gcd = GcdString.Get(str1, str2);
        
        Assert.That(gcd, Is.EqualTo(result));
    }
}