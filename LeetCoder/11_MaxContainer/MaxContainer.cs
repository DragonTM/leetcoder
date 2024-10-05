namespace LeetCoder._11_MaxContainer;

public static class MaxContainer
{
    // Bruteforce very slow
    // public static int MaxArea(int[] height)
    // {
    //     var volume = (height.Length - 1) * Math.Min(height[0], height[^1]);
    //     var r = 0;
    //     var l = height.Length - 1;
    //
    //     for (var i = 0; i < height.Length - 1; i++)
    //     {
    //         for (var j = height.Length - 1; j > i; j--)
    //         {
    //             volume = Math.Max(volume, (j - i) * Math.Min(height[j], height[i]));
    //         }
    //     }
    //
    //     return volume;
    // }

    public static int MaxArea(int[] height)
    {
        var maxVolume = 0;
        var l = 0;
        var r = height.Length - 1;

        while (l < r)
        {
            maxVolume = Math.Max((r - l) * Math.Min(height[l], height[r]), maxVolume);

            if (height[l] < height[r])
            {
                l++;
            }
            else
            {
                r--;
            }
        }

        return maxVolume;
    }
}