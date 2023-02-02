List<int> list = new List<int> { 1, 2, 3, 4, 5 };
miniMaxSum(list);


void miniMaxSum(List<int> arr)
{
    long max = 0;
    long min = Int64.MaxValue;
    long sum = 0;

    foreach (var n in arr)
    {
        sum += n;

        if (n > max)
        {
            max = n;
        }

        if (n < min)
        {
            min = n;
        }

    }

    Console.WriteLine($"{sum - max} {sum - min}");
    Console.WriteLine();
}