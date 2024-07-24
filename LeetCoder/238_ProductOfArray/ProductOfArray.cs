namespace LeetCoder._238_ProductOfArray;

public static class ProductOfArray
{
    public static int[] ProductExceptSelf(int[] nums)
    {
        var prefix = new int[nums.Length];
        prefix[0] = 1;
        var zeroCount = 0;
        for (var i = 1; i < nums.Length; i++)
        {
            prefix[i] = nums[i - 1] * prefix[i -1];

            if (nums[i] == 0)
            {
                zeroCount++;
            }
        }

        if (zeroCount > 1)
        {
            return new int[nums.Length];
        }
        
        var sufix = new int[nums.Length];
        sufix[nums.Length - 1] = 1;
        for (var i = nums.Length - 2; i >= 0; i--)
        {
            sufix[i] = nums[i+1] * sufix[i+1];
        }
        
        var result = new int[nums.Length];
        for (var i = 0; i < result.Length; i++)
        {
            result[i] = prefix[i] * sufix[i];
        }

        return result;
    }

    // Simple but slow
    // public static int[] ProductExceptSelf(int[] nums)
    // {
    //     return nums
    //         .Select((_, index) =>
    //             nums.Where((_, i) => i != index).Aggregate(1, (a, c) => a * c))
    //         .ToArray();
    // }
}