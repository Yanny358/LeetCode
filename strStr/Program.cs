// See https://aka.ms/new-console-template for more information

string haystack = "hello", needle = "ll";

Console.WriteLine(StrStr(haystack, needle));


int StrStr(string haystack, string needle)
{
    if (string.IsNullOrEmpty(haystack) && string.IsNullOrEmpty(needle))
    {
        return 0;
    }

    for (int i = 0; i < haystack.Length - needle.Length + 1; i++)
    {
        if (haystack.Substring(i, needle.Length) == needle)
        {
            return i;
        }
    }

    return -1;
}