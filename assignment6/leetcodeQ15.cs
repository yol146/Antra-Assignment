using System;

public class Class1
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        var res = new List<IList<int>>();

        if (nums == null || nums.Length == 0) return res;

        Dictionary<int, int> dic = new Dictionary<int, int>();

        foreach (int num in nums)
        {
            if (dic.ContainsKey(num)) dic[num]++;
            else dic.Add(num, 1);
        }

        int diff = 0;
        Array.Sort(nums);

        for (int i = 0; i < nums.Length - 2; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1]) continue;

            for (int j = i + 1; j < nums.Length - 1; j++)
            {
                if (j > i + 1 && nums[j] == nums[j - 1]) continue;

                diff = 0 - nums[i] - nums[j];

                if (diff > nums[j] && dic.ContainsKey(diff)) res.Add(new int[] { nums[i], nums[j], diff });
                else if (diff == nums[j] && diff == nums[j + 1]) res.Add(new int[] { nums[i], diff, diff });
            }
        }

        return res;
    }
}
