namespace LeetCoder._334_IncreasingTriplets;

[TestFixture]
public class IncreasingTripletsTests
{
    [TestCase(new[]{1,2,3,4,5}, true)]
    [TestCase(new[]{5,4,3,2,1}, false)]
    [TestCase(new[]{20,10,50,0,60,6}, true)]
    [TestCase(new[]{2,7,5,0,4,6}, true)]
    [TestCase(new[]{1,7,5,4,2,3}, true)]
    [TestCase(new[]{20,100,10,12,5,13}, true)]
    public void HasIncreasingTripletsTests(int[] nums, bool result)
    {
        var hasTriplets = IncreasingTriplets.HasIncreasingTriplet(nums);
        
        Assert.That(hasTriplets, Is.EqualTo(result));
    }
}