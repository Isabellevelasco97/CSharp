using System;
using System.Collections.Generic;

class Solution3
{
    public static IList<string> FizzBuzz(int n) {
        var iList = new List<string>();
        for (int i = 1; i <= n; i++) {
            if ((i % 15) == 0) {
                iList.Add("FizzBuzz");
            }
            else if ((i % 3) == 0) {
                iList.Add("Fizz");
            }
            else if ((i % 5) == 0) {
                iList.Add("Buzz");
            }
            else {
                iList.Add(i.ToString());
            }
        }
        iList.ForEach(Console.WriteLine);
        return iList;
    }
    public static void Main(String[] args) {
        int n = 15;
        Solution3.FizzBuzz(n);
    }
}