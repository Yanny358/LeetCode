string input = "12:40:22AM";

Console.WriteLine(timeConversion(input));

string timeConversion(string s)
{
    
    if (s.Contains('A'))
    {
        if (s[0] == '1' && s[1] == '2')
        {
            s = "00" + s[2..^2];
            return s;
        }

        s = s[..^2];
        return s;
    }

    if (s[0] == '1' && s[1] == '2')
    {
        s = s[..^2];
        return s;
    }

    s = Int32.Parse(s[..2]) + 12 + s[2..^2];

    return s;
}