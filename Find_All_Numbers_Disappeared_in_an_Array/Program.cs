// See https://aka.ms/new-console-template for more information

int[] arr = { 4, 3, 2, 7, 8, 2, 3, 1 };

var res = FindDisappearedNumbers(arr);
foreach (var num in res)
{
    Console.WriteLine(num);
}

IList<int> FindDisappearedNumbers(int[] nums)
{
    HashSet<int> numbers = new HashSet<int>();
    List<int> missingNumbers = new List<int>();
    foreach (var n in nums)
    {
        numbers.Add(n);
    }

    for (int i = 1; i <= nums.Length; i++)
    {
        if (!numbers.Contains(i))
        {
            missingNumbers.Add(i);
        }
    }

    return missingNumbers;
}
