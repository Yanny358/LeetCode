// See https://aka.ms/new-console-template for more information

int[] arr = { 4, 3, 2, 7, 8, 2, 3, 1 };

var res = FindDisappearedNumbers(arr);
foreach (var num in res)
{
    Console.WriteLine(num);
}

IList<int> FindDisappearedNumbers(int[] nums)
{
    HashSet<int> set = new HashSet<int>();
    for (int i = 1; i <= nums.Length; i++)
    {
        set.Add(i);
    }

    foreach (var num in nums)
    {
        if (set.Contains(num))
        {
            set.Remove(num);
        }
    }

    set.First();
    return set.ToArray();
}
