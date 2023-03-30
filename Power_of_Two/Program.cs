// See https://aka.ms/new-console-template for more information

bool IsPowerOfTwo(int n) {
    if (n == 1)
    {
        return true;
    }
    
    if (n % 2 != 0 || n == 0)
    {
        return false;
    }
    return IsPowerOfTwo(n / 2);
}