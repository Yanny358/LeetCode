string bnkcde = "AB11";
string accnmbr = "18-7654321";

string final = checkDetailsAreValid(accnmbr, bnkcde);
Console.WriteLine(final);

string checkDetailsAreValid(string accountNumber, string bankCode)
{
    if (!checkAccNumber(accountNumber) && !checkBankCode(bankCode))
    {
        return String.Empty;
    }
    List<string> result = new List<string>{};

    string concat = accountNumber + bankCode;
    string finalNumber = concat.Substring(3);
    var sum = numberToSum(finalNumber);
    if (sum % 2 == 0)
    {
        sum %= 89;
    }
    else
    {
        sum = 89 - (sum % 89);
    }

    return sum.ToString();
}

bool checkBankCode(string bankCode)
{
    bankCode = bankCode.Replace(" ", "");
    if (bankCode.Length != 4)
    {
        return false;
    }

    if (char.IsDigit(bankCode[0])
        && char.IsDigit(bankCode[1])
        && !char.IsDigit(bankCode[2])
        && !char.IsDigit(bankCode[3]))
    {
        return false;
    }

    return true;
}

bool checkAccNumber(string accNumber)
{
    accNumber = accNumber.Replace(" ", "");
    if (accNumber[1] == '-')
    {
        accNumber = "0" + accNumber;
    }
    var checksum = accNumber.Substring(0, 2);
    
    if (!char.IsDigit(checksum[0]) && !char.IsDigit(checksum[1]))
    {
        return false;
    }

    if (accNumber[2] != '-')
    {
        return false;
    }

    string numWithoutChecksum = accNumber.Substring(3);
    bool isParsable = int.TryParse(numWithoutChecksum, out int _);
    if (!isParsable && numWithoutChecksum.Length != 7)
    {
        return false;
    }
    
    
    return true;
}

int numberToSum(string num)
{
    int[] arr = { 7, 3, 1, 5, 2, 4, 8, 6, 1, 6, 5 };
    int sum = 0;
    num = num.ToUpper();
    for (int i = 0; i < num.Length; i++)
    {
        if (char.IsDigit(num[i]))
        {
            sum += arr[i] * (num[i] - '0');
        }
        else
        {
            sum += arr[i] * ((num[i] - 65) + 10);
        }
    }

    return sum;
}