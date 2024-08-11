namespace LeetCoder._443_Copressor;

[TestFixture]
public class CompressorTests
{
    [TestCase(new[] { 'a', 'a', 'b', 'b', 'c', 'c', 'c' }, new[] { 'a', '2', 'b', '2', 'c', '3' }, 6)]
    [TestCase(new[] { 'a' }, new[] { 'a' }, 1)]
    [TestCase(new[] { 'a', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b' },
        new[] { 'a', 'b', '1', '2' }, 4)]
    public void CompressTests(char[] chars, char[] result, int expectedLength)
    {
        var length = Compressor.Compress(chars);

        Assert.That(length, Is.EqualTo(expectedLength));
        for (var i = 0; i < expectedLength; i++)
        {
            Assert.That(chars[i], Is.EqualTo(result[i]));
        }
    }
}