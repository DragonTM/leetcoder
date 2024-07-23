namespace LeetCoder._345_ReversVowels;

public static class VowelReverser
{
    public static string ReverseVowels(string s)
    {
        var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
        
        var array = s.ToArray();

        var r = 0;
        var l = array.Length - 1;

        while (r < l)
        {
            if (vowels.Contains(array[r]) && vowels.Contains(array[l]))
            {
                (array[r], array[l]) = (array[l], array[r]);
                r++;
                l--;
            }

            if (!vowels.Contains(array[r]))
            {
                r++;
            }
            
            if (!vowels.Contains(array[l]))
            {
                l--;
            }
        }
        
        return string.Join(string.Empty, array);
    }
}