namespace LeetCoder._11_MaxContainer;

[TestFixture]
public class MaxContainerTests
{
    [TestCase(new[] { 1, 1 }, 1)]
    [TestCase(new[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }, 49)]
    [TestCase(new[] { 2, 3, 10, 5, 7, 8, 9 }, 36)]
    [TestCase(new[] { 1, 3, 2, 5, 25, 24, 5 }, 24)]
    public void MaxAreaTests(int[] height, int result)
    {
        var output = MaxContainer.MaxArea(height);

        Assert.That(output, Is.EqualTo(result));
    }
}