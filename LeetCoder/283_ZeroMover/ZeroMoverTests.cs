namespace LeetCoder._283_ZeroMover;

[TestFixture]
public class ZeroMoverTests
{
    [TestCase(new[] { 0 }, new[] { 0 })]
    [TestCase(new[] { 0, 0}, new[] { 0, 0 })]
    [TestCase(new[] { 0, 0, 1}, new[] { 1, 0, 0 })]
    public void MoveZerosTests(int[] nums, int[] result)
    {
        ZeroMover.MoveZeroes(nums);
        
        Assert.That(string.Join(",",nums), Is.EqualTo(string.Join(",", result)));
    }
}