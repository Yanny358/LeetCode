List<int> countingSort(List<int> arr)
{
    int[] counterArray = new int[100];
    foreach (var t in arr)
    {
        counterArray[t] += 1;
    } 
    return counterArray.ToList();
    
}
    /*List<int> res = new List<int>();

    Dictionary<int, int> dict = new Dictionary<int, int>();

    foreach (var num in arr)
    {
        if (!dict.ContainsKey(num))
        {
            dict.Add(num, 1);
        }
        else
        {
            dict[num]++;
        }
    }

    for (int i = 0; i < arr.Count; i++)
    {
        res.Add(dict.ContainsKey(i) ? dict[i] : 0);
    }

    return res;
}*/