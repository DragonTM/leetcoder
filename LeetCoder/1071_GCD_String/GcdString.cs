namespace LeetCoder._1071_GCD_String;

public static class GcdString
{
    public static string Get(string str1, string str2) {
        if (str2.Length > str1.Length) 
        {
            (str1, str2) = (str2, str1);
        }

        while (str1.StartsWith(str2)) 
        {
            while (str1.StartsWith(str2))
            {
                str1 = str1[str2.Length..];
            }

            if (str1 == string.Empty)
            {
                return str2;
            }

            (str1, str2) = (str2, str1);
        }

        return string.Empty;
    }
}