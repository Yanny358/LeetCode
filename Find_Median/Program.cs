int findMedian(List<int> arr)
{
    arr.Sort();
    var size = arr.Count;
    var mid = size / 2;
    var median = arr[mid];
    return median;
}