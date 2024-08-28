namespace LeetCoder._1431_Candies;

[TestFixture]
public class KidsWithCandiesTests
{
    [TestCase(new[]{2,3,5,1,3}, 3, new[] {true,true,true,false,true})]
    [TestCase(new[]{4,2,1,1,2}, 1, new[] {true,false,false,false,false})]
    [TestCase(new[]{12,1,12}, 10, new[] {true,false,true})]
    public void TestKidsWithCandies(int[] candies, int extraCandies, bool[] result)
    {
        var kidsWithCandies = KidsCandies.Get(candies, extraCandies);
        
        Assert.That(kidsWithCandies, Is.EquivalentTo(result));
    }
}