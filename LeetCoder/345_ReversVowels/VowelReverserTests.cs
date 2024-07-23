namespace LeetCoder._345_ReversVowels;

[TestFixture]
public class VowelReverserTests
{
    [TestCase("hello","holle")]
    [TestCase("leetcode","leotcede")]
    public void ReversVowelsTest(string s, string result)
    {
        var reversed = VowelReverser.ReverseVowels(s);
        
        Assert.That(reversed, Is.EqualTo(result));
    }
}