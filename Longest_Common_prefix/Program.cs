// See https://aka.ms/new-console-template for more information

string[] strings = new[] { "ab", "a" };
Console.WriteLine(LongestCommonPrefix(strings));

string LongestCommonPrefix(string[] strs)
{
    string res = string.Empty;
    if (strs.Length == 0)
    {
        return res;
    }
    
    int index = 0;
    foreach (var c in strs[0])
    {
        for (int i = 1; i < strs.Length; i++)
        {
            if (index >= strs[i].Length || c != strs[i][index])
            {
                return res;
            }
        }
        res += c;
        index++;
    }

    return res;
}