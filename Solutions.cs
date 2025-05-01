namespace LeetCodeProblems;

public class Solutions
{
    Dictionary<int, int> d = new Dictionary<int, int>(); //create a dicitonary to hold duplicates
    public int SingleNumber(int[] nums) 
    {
        foreach(int item in nums)
        {
            if (d.ContainsKey(item)) //check if the dictionary contains the item
            {
                d[item]++; //if it does increment the value by 1 for that item
            }
            else
            {
                d.Add(item, 1); //if it doesn't add the item to the dictionary with a value of 1
            }
        }

        foreach (var pair in d) //look at the kvps in the dictionary
        {
            if (pair.Value == 1) // if an item has a value of 1
            {
                return pair.Key; //return the item. this gives us all unique items in the array
            }
        }
        return -1;
    }

    public bool IsPerfectSquare(int num) 
    {
        if (num < 0) //if num is negative return false
        {
            return false;
        }

        long i = 1; //using a long because why not
        while (i * i <= num) //starting the loop with 1^2 and continue until there's a match
        {
            if (i * i == num) //once we find a match return true
            {
                return true;
            }
            i++; //keep incrementing i by 1 until we find a match
        }
        return false;
    }
    
    public int[] TwoSum(int[] nums, int target) // trying to add two numbers in an array to match the target
    {
        for (int i = 0; i < nums.Length; i++) //loop through the array with 1 pointer
        {
            for(int j = i + 1 ; j < nums.Length; j++) //loop through the array with 2 pointer
            {
                if(nums[i] + nums[j] == target) //add the values at each pointer and compare to the target
                {
                    return [i, j]; //return the indices of the two numbers that add up to the target
                }
            }
        }
        return [];//if no match is found return an empty array        
    }
}