using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
class Solution4
{
    // Approach 1, solved by sorting
    // only finds first duplicate in given int array
    public static int FindDuplicate(int[] nums)
    {
        Array.Sort(nums);
        // Printing to make sure sorted bcus I have trust issues
        foreach (int element in nums) {
            Console.WriteLine(element.ToString());
        }
        // looping thru nums array tp find the duplicate
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] == nums[i-1])
            {
                // printing out duplicate is it's there
                Console.WriteLine("\n" + nums[i]);
                // also returning it
                return nums[i];
            }
        }
        // base case returns -1 if there is no duplicate
       return -1;
    }

    public static bool isThereDuplicate(int[] nums)
    {
       int size = nums.Length;
       HashSet<int> set1 = new HashSet<int>();

       for (int i = 0; i < size; i++)
       {
           if (set1.Contains(nums[i]))
           {
                return true;
           }
           else
           {
                set1.Add(nums[i]);
           }
       }
       return false; 
    }

    // Appriach 2, solved with set
    public static int findDuplicate2(int[] nums)
    {
        // create new hashset
        HashSet<int> seen = new HashSet<int>();
        // loops thru each element in nums
        foreach (int duplicate in nums)
        {
            if (seen.Contains(duplicate)) // hashset knows if the element contains duplicates
            // still not sure how or why it just does 【・_・?】
            {
                return duplicate;
            }
            // need to add these elements to hashset
            seen.Add(duplicate);
        }
        return -1;
        // hashsets are cool, can also remove stuff from them and whatnot
        
    }
    public static void Main(string[] args)
    {
        int[] nums = new int[] {1,3,4,2,4,1};
        //Solution4.FindDuplicate(nums);


    }

}