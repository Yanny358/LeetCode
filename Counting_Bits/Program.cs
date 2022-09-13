
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

int Count1Bit(int no)
{
    int count = 0;
    if (no <= 0)
        throw new Exception("No. should be greater than 0");
    while (no > 0)
    {
        if (no % 2 != 0)
            count++;
        no /= 2;
    }
    return count;
}