string s = "abcd";
Console.WriteLine(subStringsWithNoRepeat(s));

int subStringsWithNoRepeat(string S)
{
    if (string.IsNullOrEmpty(S))
    {
        return 0;
    }

    HashSet<int> substring = new HashSet<int>();
    int result = 1;
    foreach (char c in S)
    {
        if (substring.Contains(c))
        {
            result++;
            substring.Clear();
        }

        substring.Add(c);
    }

    return result;
}

int[] blockss = new[] { 2,6,8,5};

Console.WriteLine(solution(blockss));

int solution(int[] blocks)
{
    int result = 0;
    for (int i = 0; i < blocks.Length; i++)
    {
        var jump = i;
        
        while (jump > 0 && blocks[jump - 1] >= blocks[jump])
        {
            jump -= 1;
        }
        
        var low = jump;
        jump = i;

        while (jump < blocks.Length - 1 &&  blocks[jump + 1] >= blocks[jump])
        {
            jump += 1;
        }

        var high = jump;
        result = Math.Max(result, high - low);
    }

    return result + 1;
}


