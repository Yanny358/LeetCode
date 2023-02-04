List<List<int>> list = new()
    { new List<int>() { 1, 2, 3 }, new List<int>() { 4, 5, 6 }, new List<int>() { 9, 8, 9 } };
Console.WriteLine(diagonalDifference(list));

int diagonalDifference(List<List<int>> arr)
{
    int dig1 = 0;
    int dig2 = 0;

    for (int i = 0; i < arr.Count; i++)
    {
        dig1 += arr[i][i];
    }

    for (int i = arr.Count - 1; i >= 0; i--)        //1 2 3
                                                    //4 5 6
                                                    //9 8 9
    {
        dig2 += arr[arr.Count - 1 - i][i];
    }

    var sum = Math.Abs(dig1 - dig2);
    return sum;
}