namespace LeetCoder._334_IncreasingTriplets;

public static class IncreasingTriplets
{
    public static bool HasIncreasingTriplet(int[] nums)
    {
        if (nums.Length < 3)
        {
            return false;
        }

        var smallest = int.MaxValue;
        var secondSmallest = int.MaxValue;

        foreach (var num in nums)
        {
            if (num <= smallest)
                smallest = num;
            else if (num <= secondSmallest)
                secondSmallest = num;
            else
                return true; // It does not identify the indexes for the tiplet it ensures it exists 
        }

        return false;
    }
}