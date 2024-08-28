namespace LeetCoder._392_Subsequence;

public static class Subsequence
{
    public static bool IsSubsequence(string s, string t)
    {
        if (s.Length > t.Length)
        {
            return false;
        }
        
        if (s == string.Empty)
        {
            return true;
        }

        var subsequenceIndex = 0;

        foreach (var ch in t)
        {
            if (s[subsequenceIndex] == ch)
            {
                subsequenceIndex++;
            }

            if (subsequenceIndex >= s.Length)
            {
                return true;
            }
        }

        return false;
    }
}