namespace LeetCoder._443_Copressor;

public static class Compressor
{
    public static int Compress(char[] chars)
    {
        if (chars.Length == 1)
        {
            return 1;
        }
        
        var symbol = chars[0];
        var counter = 1;
        var index = 0;

        for (var i = 1; i < chars.Length; i++)
        {
            if (chars[i] == symbol)
            {
                counter++;
            }
            else
            {
                chars[index++] = symbol;

                if (counter > 1)
                {
                    var counterString = counter.ToString();

                    foreach (var counterChar in counterString)
                    {
                        chars[index++] = counterChar;
                    }
                }

                symbol = chars[i];
                counter = 1;
            }
        }
        
        chars[index++] = symbol;

        if (counter > 1)
        {
            var counterString = counter.ToString();

            foreach (var counterChar in counterString)
            {
                chars[index++] = counterChar;
            }
        }
        
        return index;
    }
}