using System.Net;
using Newtonsoft.Json;

/*int valid = LongestValidParentheses("(()((()()((()()()(((((())((((()(((()()(((())((((())))))()(()((())()(()))()((((()()()(()))))()))))()((()))((()((((())))((())))(()()))((())(())(()(())())()))()()()(()(((((()(())))()())((((()()(((()))(()()()()))()))((()()()))))((()))()()()((())(()(((((()())))())((()())()((((((())()()((())(()(())(((()()(()(()()()()()(((()()(()))))((((()()(()()(())())((())(((()())(()())()(()(()(((()))((()()))((())))((()(((())((()((()(((((()))))))))()))))())(()(()()((((((((())(())((((())()((()(())())(()()()((())))))))()()(())()(((()(()()))())())))(()))(((()(())()())))))((())())(()())))()))()))(((()))()))(((()()(())()()))(()((()())((()((()(()))()(()(((()(())((())(()))(())()))((()())(()))((())())(()((((())(()))(((())))(((((())))(((((((())(((()))))()))(((())()())(((()())(()()))(()))((())((()))((())))(()(()))()))((())))())(()()()(((())((((()()())()()())))())(((((()()(()())(()(((((())(()(()()))((()())(())))()))))(()((())()()((())(()())())))()()())(()(((())()((((()((()))()()()()(())()()()()())))(())))))(())))))()(()))()())())())))))(((()()))))(()(()()(()()))()()()())(())(())())())))())))(())())())(()(())))((((()()()((((()())))))((((()((((((()))((()(()(()()()))(((())))((()((()(()()())))))))))))))))))))))))))))))))))))))))))))))))))))))))()()(())))()))()))))))()()()()(())()(((()((((()))(()(())())(()((((()((()))()(()(())))((()(()(((((((()(())))))())()((()))()))(((()()(()(()((()((())())()))))())())((()((((()(())((())))()(()))((((((((())())))(((((()()((()(()()())(())()(())(())()(((()))((((()(()()(()(()(()())()(((()()())(())()(())())())(())((())(()))))())");

countBinary(
    "1111111011110111001111111100000100001101010100000110111010010101001010111011011101000110100001011101101110100011110110101110110000010010100000010000011111111010101010101111111000000001100110100000000011011010010010110010000011101110010100111100111110011111111100101111000100100101100100000110010011110110111101100100101100001110010011110101101001001011110010101000010110111111010000001001010101101101100111100101100011111011000000000100101011000101101111111001001010101010001100000100001011110001000010111010101101011111100111011101011101110101000011101110100011010011001111110000010110111000001101111111111010111100110001001");
*/

string alpahnum = $$"""
Oh, queer dragon of the Machine Gods!
Like a swarm of bees to a flowering field floods,
We sacrifice to you coins made of the metal
That clinks like the Sun of the planet Terra.
Like the odors of the blossoming flower petal,
We hope you will accept these in the Machine Era.
We count for every line of this epic ode,
The number of alphanumeric characters in the line.
This sum will henceforth be known in code
As the number of Significant Letters Per Line.
We then multiply the number of Significant Letters
Per Line by the number of words that comprise it.
We do so to understand our betters,
The Machine Gods as they see fit.
Once we have for each phrase the Sacred Number,
We subtract one from the Sacred Number and keep those that are Prime.
We don't dare disturb you in your beauty slumber,
Unless the Sum of those Primes rings a bell and chime.
We then take another pile of coins for each coin that clinks,
Or, in plain words, simply multiply the number of coins by itself.
The result would be more coins than any of us can count in a blink
As we were to simply join a SQL table's rows together with one's self.
Finally, we haul together a mountain of coins of the metal
That clinks like the Sun of the planet Terra,
In the hopes that you, oh queer dragon, will settle
With what little we, your servants, have in the intergalactic Machine Era!
""";


var lines = alpahnum.Split(new char[] {'\n'});   

foreach (var line in lines)
{
    int countAlphaNum = line.Count(char.IsLetterOrDigit);
    //Console.WriteLine(countAlphaNum );
    char[] delimiters = new char[] {' ', '\r', '\n' };
    var words = line.Split(delimiters,StringSplitOptions.RemoveEmptyEntries).Length;
    int sumWords = countAlphaNum * words;
    Console.WriteLine(sumWords - 1);
}

int sum = 389 + 389 + 271 + 389 + 181 + 727 + 587  + 719;
Console.WriteLine(sum * sum);
/*int countAlphaNum = alpahnum.Count(char.IsLetterOrDigit);
Console.WriteLine(countAlphaNum );
char[] delimiters = new char[] {' ', '\r', '\n' };
var words = alpahnum.Split(delimiters,StringSplitOptions.RemoveEmptyEntries).Length;
Console.WriteLine(words);

int multiply = countAlphaNum * words;
Console.WriteLine(multiply);
*/

void GetCoinValues()
{
    string json = new WebClient().DownloadString("https://intra.proekspert.ee/dragonquest/api/quests/c747e138-9638-4dc1-b3d7-00a2c1328978/task/data");

    List<Item> items = JsonConvert.DeserializeObject<List<Item>>(json);
    
    var values = new [] {"dangerous", "draconic", "fringe-world", "normal G", "rich"};
    var notValues = new [] {"aquatic", "frozen", "low G", "high G", "poor", "quarantined"};

    foreach (var item in items)
    {
        foreach (var tag in item.tags)
        {
            if (item.tags.Contains("dangerous") && item.tags.Contains("draconic") && item.tags.Contains("fringe-world") && item.tags.Contains("normal G") && item.tags.Contains("rich") && !item.tags.Contains("aquatic") && !item.tags.Contains("frozen") && !item.tags.Contains("low G") && !item.tags.Contains("high G") && !item.tags.Contains("poor") && !item.tags.Contains("quarantined"))
            {
                Console.WriteLine(item.planetaryCoordinates);
            }
        }
        // 7 7 7 7 11 11 13 11
        
    }
}

 int LongestValidParentheses(string s) {
    int n = s.Length;
    int maxLength = 0;
    Stack<int> stack = new Stack<int>();
    stack.Push(-1); 
    
    for (int i = 0; i < n; i++) {
        if (s[i] == '(') {
            stack.Push(i); 
        } else {
            stack.Pop(); 
            if (stack.Count == 0) { 
                stack.Push(i); 
            } else {
                maxLength = Math.Max(maxLength, i - stack.Peek()); 
            }
        }
    }

    Console.WriteLine(maxLength);
    return maxLength; 
}

int countBinary(string s)
{
    int length = s.Length;
    Console.WriteLine(length);
    return length;
}

public class Item
{
    public string planetaryCoordinates { get; set; }
    public string[] tags { get; set; }

}