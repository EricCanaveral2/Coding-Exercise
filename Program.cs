using System;
using System.Collections.Generic;

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> numMap = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (numMap.ContainsKey(complement))
            {
                return new int[] { numMap[complement], i };
            }
            if (!numMap.ContainsKey(nums[i]))
            {
                numMap.Add(nums[i], i);
            }
        }
        throw new ArgumentException("No two sum solution");
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the array of integers separated by spaces:");
        int[] nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        Console.WriteLine("Enter the target integer:");
        int target = int.Parse(Console.ReadLine());

        Solution solution = new Solution();
        int[] result = solution.TwoSum(nums, target);
        Console.WriteLine("Indices of the two numbers: [{0}, {1}]", result[0], result[1]);
    }
}
