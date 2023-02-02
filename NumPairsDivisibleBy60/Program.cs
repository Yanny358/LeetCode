// See https://aka.ms/new-console-template for more information
int[] time = { 30,20,150,100,40 };
int res = NumPairsDivisibleBy60(time);
Console.WriteLine(res);

int NumPairsDivisibleBy60(int[] time)
{
    int result = 0;
    int[] remainderCount = new int[60];
    for (int i = 0; i < time.Length; i++)
    {
        int remainder = time[i] % 60;
        if (remainder == 0)
        {
            result += remainderCount[0];
        }
        else
        {
            result += remainderCount[60 - remainder];
        }
 
        remainderCount[remainder]++;
    }
    
    return result;
}