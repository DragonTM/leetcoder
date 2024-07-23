namespace LeetCoder._238_ProductOfArray;

[TestFixture]
public class ProductOfArrayTests
{
    [TestCase(new int[]{1,2,3,4}, new int[]{24,12,8,6})]
    [TestCase(new int[]{-1,1,0,-3,}, new int[]{0,0,9,0,0})]
    public void ProductExceptSelfTest(int[] nums, int[] result)
    {
        var product = ProductOfArray.ProductExceptSelf(nums);
        
        Assert.That(product, Is.EquivalentTo(result));
    }
}