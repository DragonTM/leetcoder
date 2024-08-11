namespace LeetCoder._1431_Candies;

[TestFixture]
public class KidsWithCandiesTests
{
    [TestCase(new int []{2,3,5,1,3}, 3, new bool[] {true,true,true,false,true})]
    [TestCase(new int []{4,2,1,1,2}, 1, new bool[] {true,false,false,false,false})]
    [TestCase(new int []{12,1,12}, 10, new bool[] {true,false,true})]
    public void TestKidsWithCandies(int[] candies, int extraCandies, bool[] result)
    {
        var kidsWithCandies = KidsCandies.Get(candies, extraCandies);
        
        Assert.That(kidsWithCandies, Is.EquivalentTo(result));
    }
}