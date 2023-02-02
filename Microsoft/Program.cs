using System;
namespace Microsoft
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "ab";
            string goal = "ba";
            //Console.WriteLine(BuddyStrings(s1,goal));
            string bigS = "aabcASDB";
            Console.WriteLine(one(bigS));
        }


        public int[] two(int N) {
            int sum = 0;
            int[] result = new int[N];
            for(int i = 0; i < N; i++){
                result[i] = i;
                sum+= result[i];
            }
            result[0] = -sum;
            return result;
        }
        
        
        public static string one(string S)
        {
            bool[] uppercase = new bool[26];
            bool[] lowercase = new bool[26];
 
            char[] arr = S.ToCharArray();
 
            foreach(char c in arr)
            {
                if (char.IsLower(c))
                    lowercase[c - 'a'] = true;
 
                if (char.IsUpper(c))
                    uppercase[c - 'A'] = true;
            }
 
            for(int i = 25; i >= 0; i--)
            {
                
                if (uppercase[i] && lowercase[i])
                    return (char)(i + 'A') + "";
            }
                

            return "NO";
        }
        

        public static bool BuddyStrings(string s, string goal)
        {
            if (s.Length != goal.Length)
            {
                return false;
            }

            if (s == goal)
            {
                return s.Distinct().Count() < s.Length;
            }

            var diffs = new List<int>();
            for (var i = 0; i < s.Length; i++)
            {
                if (s[i] != goal[i])
                {
                    diffs.Add(i);
                }
            }

            return diffs.Count == 2 && s[diffs[0]] == goal[diffs[1]] && s[diffs[1]] == goal[diffs[0]];
        }
    }
}