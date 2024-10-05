namespace LeetCoder._643_MaxAvgSum;

public static class MaxAvgSum
{
    public static double FindMaxAverage(int[] nums, int k)
    {
        var sum = 0d;

        for (var i = 0; i < k; i++)
        {
            sum += nums[i];
        }

        var maxSum = sum;

        for (var i = k; i < nums.Length; i++)
        {
            sum -= nums[i - k];
            sum += nums[i];
            
            maxSum = Math.Max(maxSum, sum);
        }
        
        return maxSum / k;
    }
}