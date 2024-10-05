namespace LeetCoder._1679_Ksum;

[TestFixture]
public class KsumFinderTests
{
    [TestCase(new[] { 1, 2, 3, 4 }, 5, 2)]
    [TestCase(new[] { 3, 1, 3, 4, 3 }, 6, 1)]
    public void MaxOperationsTests(int[] nums, int k, int result)
    {
        var operations = KsumFinder.MaxOperations(nums, k);

        Assert.That(operations, Is.EqualTo(result));
    }
}