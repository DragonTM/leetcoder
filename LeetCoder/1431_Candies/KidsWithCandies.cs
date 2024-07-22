namespace LeetCoder._1431_Candies;

public static class KidsWithCandies
{
    public static IList<bool> Get(int[] candies, int extraCandies)
    {
        var max = candies.Max();

        var result = new bool[candies.Length];
        
        for (var i = 0; i < result.Length; i++)
        {
            result[i] = candies[i] + extraCandies >= max;
        }
        
        return result;
    }
    
    // Solution 1
    // public static IList<bool> Get(int[] candies, int extraCandies)
    // {
    //     var max = candies.Max();
    //     
    //     return candies.Select(c => c + extraCandies >= max).ToArray();
    // }
}