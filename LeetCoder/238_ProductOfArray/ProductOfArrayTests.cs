namespace LeetCoder._238_ProductOfArray;

[TestFixture]
public class ProductOfArrayTests
{
    [TestCase(new[]{1,2,3,4}, new[]{24,12,8,6})]
    [TestCase(new[]{-1,1,0,-3,3}, new[]{0,0,9,0,0})]
    public void ProductExceptSelfTest(int[] nums, int[] result)
    {
        var product = ProductOfArray.ProductExceptSelf(nums);
        
        Assert.That(product, Is.EquivalentTo(result));
    }
}