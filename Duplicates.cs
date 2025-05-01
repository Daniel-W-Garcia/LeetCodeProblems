namespace LeetCodeProblems;

public class Duplicates
{
    public bool ContainsDuplicate(int[] nums) //this works but on large arrays it's terrible O(n^2)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = nums.Length - 1; j > i; j--)
            {
                if (nums[i] == nums[j])
                {
                    return true;
                }
            }
        }
        return false;
    }
    public bool ContainsDuplicate2(int[] nums) 
    {
        Array.Sort(nums);
    
        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] == nums[i + 1])
            {
                return true;
            }
        }
        return false;
    }
    public int RemoveDuplicates(int[] nums) 
    {
        if (nums.Length == 0) return 0;

        int uniqueIndex = 0;
        
        for (int i = 1; i < nums.Length; i++) //start at 1 because 0th element is already unique
        {
            if (nums[i] != nums[uniqueIndex]) //compare i with last unique element
            {
                uniqueIndex++; //i is unique so increment uniqueIndex by 1 to point to next unique element
                nums[uniqueIndex] = nums[i]; //copy i to unique element to compare with next element
            }
        }
        
        return uniqueIndex + 1; //count of each unique element in the array
    }
}