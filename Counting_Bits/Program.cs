
CountBits(5);

int[] CountBits(int n)
{
    int[] arrOfBits = new int[n + 1];
    for (int i = 1; i <= n; i++)
    {
        arrOfBits[i] = Count1Bit(i);
    }

    return arrOfBits;
}

int Count1Bit(int number)
{
    int count = 0;
    if (number <= 0)
        throw new Exception("No. should be greater than 0");
    while (number > 0)
    {
        if (number % 2 != 0)
            count++;
        number /= 2;
    }
    return count;
}