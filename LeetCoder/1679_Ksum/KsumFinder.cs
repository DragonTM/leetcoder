namespace LeetCoder._1679_Ksum;

public static class KsumFinder
{
    public static int MaxOperations(int[] nums, int k)
    {
        Array.Sort(nums);

        var l = 0;
        var r = nums.Length - 1;
        var operations = 0;

        while (l < r)
        {
            var diff = nums[l] + nums[r] - k;
            
            switch (diff)
            {
                case 0:
                    l++;
                    r--;
                    operations++;
                    break;
                case > 0:
                    r--;
                    break;
                case < 0:
                    l++;
                    break;
            }
        }

        return operations;
    }
    
    // public static int MaxOperations(int[] nums, int k)
    // {
    //     var operation = 0;
    //     var pairs = new Dictionary<int, int>();
    //
    //     foreach (var num in nums)
    //     {
    //         var diff = k - num;
    //         if (pairs.TryGetValue(diff, out var value) && value > 0)
    //         {
    //             pairs[diff] = --value;
    //             operation++;
    //         }
    //         else
    //         {
    //             if (!pairs.TryAdd(num, 1))
    //             {
    //                 pairs[num]++;
    //             }
    //         }
    //     }
    //     
    //     return operation;
    // }
}