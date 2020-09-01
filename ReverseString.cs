using System;
class Solution2
{
    // reversing string array of char using two pointer method
    // time complexity of O(n) space comopexity O(1)
    public static void reverseString(char[] s)
    {
        int i = 0;
        int j = s.Length - 1;
        while(i < j){
            // swaps first and last elements
            char k = s[i];
            s[i] = s[j];
            s[j] = k;
            // increments i and subtracts j
            i++;
            j--;
        }
        foreach(char item in s) {
            Console.WriteLine(item.ToString());
        }
    }
    public static void Main(String[] args)
    {
        // any given char array
        char[] s = new char[] {'h', 'e', 'l', 'l', 'l', 'o'};
        Solution2.reverseString(s);
    }
}