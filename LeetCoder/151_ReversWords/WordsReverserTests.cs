namespace LeetCoder._151_ReversWords;

[TestFixture]
public class WordsReverserTests
{
    [TestCase("the sky is blue", "blue is sky the")]
    [TestCase("  hello world  ", "world hello")]
    [TestCase("a good   example", "example good a")]
    public void ReverseWordsTests(string s, string result)
    {
        var reversed = WordsReverser.ReverseWords(s);

        Assert.That(reversed, Is.EqualTo(result));
    }
}