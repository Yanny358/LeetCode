// See https://aka.ms/new-console-template for more information

Console.WriteLine(MyAtoi("21474836460"));

int MyAtoi(string s)
{
    if (string.IsNullOrWhiteSpace(s))
    {
        return 0;
    }

    long result = 0;
    s = s.Trim();
    int sign = 1;
    string str = "";
    
    int index = 0;
    if (s[0] == '-' || s[0] == '+')
    {
        sign = s[0] == '-' ? sign = -1 : sign = 1;
        index++;
    }

    while (index < s.Length)
    {
        if (!char.IsDigit(s[index]))
        {
            break;
        }

        str += s[index];
       
        result = long.Parse(str) * sign;
        if (result > int.MaxValue) return int.MaxValue;
        if (result < int.MinValue) return int.MinValue;
        index++;
    }

    return (int)result;
}