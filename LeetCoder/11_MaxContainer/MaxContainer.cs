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
        var volume = (height.Length - 1) * Math.Min(height[0], height[^1]);
        var r = 0;
        var l = height.Length - 1;
    
        while (r < l)
        {
            var volume1 = (l - r - 1) * Math.Min(height[r + 1], height[l]);
            var volume2 = (l - r - 1) * Math.Min(height[r], height[l - 1]);
    
            volume = new[] { volume1, volume2, volume }.Max();
    
            if (volume1 > volume2)
            {
                r++;
            }
            else
            {
                l--;
            }
        }
    
        return volume;
    }
}