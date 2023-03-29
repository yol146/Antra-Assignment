using System;

public class Solution
{

    // Leetcode question1:
    public int[] TwoSum(int[] nums, int target)
    {
        int[] result = new int[2];
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                if (i != j & nums[i] + nums[j] == target)
                {
                    result[0] = i;
                    result[1] = j;
                    return result;
                }
            }
        }
        return result;
    }

    // Leetcode question 9:
    public bool isPalindrome(int x)
    {
        string str = x.ToString();
        bool result = true;
        for (int i = 0; i < (str.Length / 2); i++)
        {
            char w = str[i];
            char w2 = str[str.Length - 1 - i];
            if (w != w2)
            {
                result = false;
                return result;
            }
        }
        return result;
    }


    //Leetcode 217
    public bool ContainsDuplicate(int[] nums)
    {
        Dictionary<int, int> myDic = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (myDic.ContainsKey(nums[i]))
            {
                return true;
            }
            else
            {
                myDic.Add(nums[i], 1);
            }
        }
        return false;
    }

    //Leetcode 412
    public IList<string> FizzBuzz(int n)
    {
        List<string> result = new List<string>();
        for (int i = 1; i <= n; i++)
        {
            if (i % 15 == 0)
            {
                result.Add("FizzBuzz");
            }
            else if (i % 3 == 0)
            {
                result.Add("Fizz");
            }
            else if (i % 5 == 0)
            {
                result.Add("Buzz");
            }
            else
            {
                result.Add(i.ToString());
            }
        }
        return result;
    }







}



