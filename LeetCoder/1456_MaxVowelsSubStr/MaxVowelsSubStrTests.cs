namespace LeetCoder._1456_MaxVowelsSubStr;

[TestFixture]
public class MaxVowelsSubStrTests
{
    [TestCase("abciiidef", 3, 3)]
    [TestCase("aeiou", 2, 2)]
    [TestCase("leetcode", 3, 2)]
    public void MaxVowelsTests(string s, int k, int result)
    {
        var maxVowels = MaxVowelsSubStr.MaxVowels(s, k);
        
        Assert.That(maxVowels, Is.EqualTo(result));
    }
}