namespace LeetCoder._605_PlaceFlowers;

[TestFixture]
public class PlaceFlowersTests
{
    [TestCase(new int[] {1,0,0,0,1}, 1, true)]
    [TestCase(new int[] {1,0,0,1,0}, 1, false)]
    [TestCase(new int[] {1,0,0,0,1}, 2, false)]
    [TestCase(new int[] {0,0,0,0,0}, 3, true)]
    [TestCase(new int[] {0,0,0,0,0}, 4, false)]
    public void CanPlaceFlowersTests(int[] flowerbed, int n, bool result)
    {
        var canPlace = PlaceFlowers.CanPlaceFlowers(flowerbed, n);
        
        Assert.That(canPlace, Is.EqualTo(result));
    }
}