namespace LeetCoder._1456_MaxVowelsSubStr;

public static class MaxVowelsSubStr
{
    public static int MaxVowels(string s, int k)
    {
        var maxVowels = 0;
        var vowelsSet = new HashSet<char> {'a', 'e', 'i', 'o', 'u'};

        for (var i = 0; i < k; i++)
        {
            if (vowelsSet.Contains(s[i]))
            {
                maxVowels++;
            }
        }
        
        var vowels = maxVowels;

        for (var i = k; i < s.Length; i++)
        {
            if (vowelsSet.Contains(s[i - k]))
            {
                vowels--;
            }

            if (vowelsSet.Contains(s[i]))
            {
                vowels++;
            }

            maxVowels = Math.Max(vowels, maxVowels);
        }
        
        return maxVowels;
    }
}