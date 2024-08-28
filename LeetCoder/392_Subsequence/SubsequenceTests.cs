namespace LeetCoder._392_Subsequence;

[TestFixture]
public class SubsequenceTests
{
    [TestCase("abc", "ahbgdc", true)]
    [TestCase("axc", "ahbgdc", false)]
    public void IsSubsequenceTests(string s, string t, bool result)
    {
        var output = Subsequence.IsSubsequence(s, t);
        
        Assert.That(output, Is.EqualTo(result));
    }
}