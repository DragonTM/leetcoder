namespace LeetCoder._643_MaxAvgSum;

[TestFixture]
public class MaxAvgSumTests
{
    [TestCase(new[] { 1,12,-5,-6,50,3}, 4, 12.75000)]
    public void FindMaxAverageTests(int[] nums, int k, double result)
    {
        var maxAvg = MaxAvgSum.FindMaxAverage(nums, k);
        
        Assert.That(Math.Abs(maxAvg - result), Is.LessThan(0.00001));
    }
}