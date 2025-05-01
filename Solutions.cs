namespace LeetCodeProblems;

public class Solutions
{
    Dictionary<int, int> d = new Dictionary<int, int>();
    public int SingleNumber(int[] nums) 
    {
        foreach(int item in nums)
        {
            if (d.ContainsKey(item))
            {
                d[item]++;
            }
            else
            {
                d.Add(item, 1);
            }
        }

        foreach (var pair in d)
        {
            if (pair.Value == 1)
            {
                return pair.Key;
            }
        }
        return -1;
    }

    public bool IsPerfectSquare(int num) 
    {
        if (num < 0)
        {
            return false;
        }

        long i = 1;
        while (i * i <= num)
        {
            if (i * i == num)
            {
                return true;
            }
            i++;
        }
        return false;
    }
    
    public int[] TwoSum(int[] nums, int target) 
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for(int j = i + 1 ; j < nums.Length; j++)
            {
                if(nums[i] + nums[j] == target)
                {
                    return [i, j];
                }
            }
        }
        return [];        
    }
    
}