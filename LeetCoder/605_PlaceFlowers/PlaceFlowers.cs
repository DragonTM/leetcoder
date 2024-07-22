namespace LeetCoder._605_PlaceFlowers;

public static class PlaceFlowers
{
    public static bool CanPlaceFlowers(int[] flowerbed, int n)
    {
        var i = 0;
        while (n > 0 && i < flowerbed.Length)
        {
            if (Math.Ceiling((flowerbed.Length - i) / 2.0) < n)
            {
                return false;
            }
            
            if (flowerbed[i] == 1)
            {
                i++;
            }
            else if  (i < flowerbed.Length - 1 && flowerbed[i + 1] == 1)
            {
                i += 2;
            }
            else
            {
                n--;
                i++;
            }

            i++;
        }
        
        return n == 0;
    }
    
    // 0 0 0 0 0 0
    // 1 0 1 0 1 0
    // 1 0 0 0 1 0
    // 1 0 1 0 1 0 1
}