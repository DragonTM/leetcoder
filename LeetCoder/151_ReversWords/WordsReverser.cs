namespace LeetCoder._151_ReversWords;

public static class WordsReverser
{
    public static string ReverseWords(string s) {
        return string.Join(" ", s.Trim().Split(" ").Where(w => !string.IsNullOrWhiteSpace(w)).Reverse());
    }
}