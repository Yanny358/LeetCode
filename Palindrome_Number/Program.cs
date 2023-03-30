bool isPalindrome(int x) {
        string numToString = x.ToString();
        int length = numToString.Length;
        for (int i = 0; i < length / 2; i++)
        {
                if (numToString[i] != numToString[length - i - 1])
                {
                        return false;
                }
        }

        return true;
        
        // return x.ToString() == new string(x.ToString().Reverse().ToArray());
        /*
         * int rev =0;
        int original = x;
        while(x !=0){
            int num = x % 10;
            rev = rev *10 + num;
            x = x/10;

        }

        if(original >= 0 && original == rev){
            return true;
        }

        return false;
         */
}