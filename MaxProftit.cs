using System;
class Solution
{
    public static int maxProfit(int[] prices)
    {
        if (prices.Length == 0) {
            return 0;
        }
        int maxProfit = 0;
        int low = prices[0];
        for (int i = 0; i < prices.Length; i++) {
            low = Math.Min(low, prices[i]);
            maxProfit = Math.Max((prices[i] - low), maxProfit);
        }
        Console.WriteLine(low);
        Console.WriteLine(maxProfit);
        return maxProfit;
    }

    public static void Main(String[] args) 
    {
        int[] numbers = new int[] {7,1,5,3,6,4};
        maxProfit(numbers);
    }
}