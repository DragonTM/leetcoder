namespace LeetCoder._283_ZeroMover;

public static class ZeroMover
{
    public static void MoveZeroes(int[] nums) {
        if (nums.Length < 2)
        {
            return;
        }

        var r = nums.Length;

        while (nums[r-1] == 0 && r > 1)
        {
            r--;
        }

        if (r == 1)
        {
            return;
        }

        var l = 0;
        while (l < r)
        {
            if (nums[l] != 0)
            {
                l++;
                continue;
            }
            
            for (var j = l; j < r - 1; j++)
            {
                (nums[j], nums[j + 1]) = (nums[j + 1], nums[j]);
            }

            r--;
        }
    }
}