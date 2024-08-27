namespace LeetCoder._283_ZeroMover;

[TestFixture]
public class ZeroMoverTests
{
    [TestCase(new int[] { 0 }, new int[] { 0 })]
    [TestCase(new int[] { 0, 0}, new int[] { 0, 0 })]
    [TestCase(new int[] { 0, 0, 1}, new int[] { 1, 0, 0 })]
    public void MoveZerosTests(int[] nums, int[] result)
    {
        ZeroMover.MoveZeroes(nums);
        
        Assert.That(string.Join(",",nums), Is.EqualTo(string.Join(",", result)));
    }
}