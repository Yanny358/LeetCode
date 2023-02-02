List<int> list = new List<int> { -4, 3, -9, 0, 4, 1 };
plusMinus(list);


void plusMinus(List<int> arr)
{
    decimal len = arr.Count;
    decimal countPos = 0;
    decimal countNeg = 0;
    decimal countZeros = 0;

    foreach (var num in arr)
    {
        if (num > 0)
        {
            countPos++;
        }
        else if (num < 0)
        {
            countNeg++;
        }
        else
        {
            countZeros++;
        }
    }
    Console.WriteLine((countPos / len).ToString("0.000000"));
    Console.WriteLine((countNeg / len).ToString("0.000000"));
    Console.WriteLine((countZeros / len).ToString("0.000000"));
}
