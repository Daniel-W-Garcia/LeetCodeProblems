namespace LeetCodeProblems;

public class MathRelated
{
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
    
    public int mySqrt(int x) //method looks for largest int that can be squared and be less than or equal to x
    {
        if (x == 0) return 0;
        
        long left = 1;
        long possibleAnswer = 0;
        long right = x;

        while (left <= right)
        {
            long mid = left + (right - left) / 2; //this calculates the mid point between left and x
            
            if (mid * mid <= x) // as long as mid^2 is less than x we can check the next int. 
            {
                possibleAnswer = mid; // mid * mid is less than x so we store it in possibleAnswer and return it as the answer if the next iteration is false
                left = mid + 1; // we move the left value to the next int
            }
            else
            {
                right = mid - 1; // If mid*mid > x, we need to look at smaller values so we move the right value to the previous int and leave the left value alone
            }
        }
        return (int)possibleAnswer; //cast possibleAnswer from a long into an int and return it as the answer
    }
}