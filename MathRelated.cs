using System.Text;

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
            for (int j = i + 1; j < nums.Length; j++) //loop through the array with 2 pointer
            {
                if (nums[i] + nums[j] == target) //add the values at each pointer and compare to the target
                {
                    return [i, j]; //return the indices of the two numbers that add up to the target
                }
            }
        }

        return []; //if no match is found return an empty array        
    }

    public int mySqrt(int x) //method looks for largest int that can be squared and be less than or equal to x
    {
        if (x == 0) return 0;

        long left = 1;
        long possibleAnswer = 0;
        long right = x;
        Math.Sqrt(x);

        while (left <= right)
        {
            long mid = left + (right - left) / 2; //this calculates the mid point between left and x

            if (mid * mid <= x) // as long as mid^2 is less than x we can check the next int. 
            {
                possibleAnswer =
                    mid; // mid * mid is less than x so we store it in possibleAnswer and return it as the answer if the next iteration is false
                left = mid + 1; // we move the left value to the next int
            }
            else
            {
                right = mid -
                        1; // If mid*mid > x, we need to look at smaller values so we move the right value to the previous int and leave the left value alone
            }
        }

        return (int) possibleAnswer; //cast possibleAnswer from a long into an int and return it as the answer
    }


    // string inputs are base 2
    // add a and b together. when a and b both have a 1 in the same posiiton, the 1 needs to be carried
    // iterate over each string starting from the right
    // if both values are 1 we need to make that a 0 and carry the 1

    public string AddBinary(string firstString, string secondString)
    {
        // Result will be built in reverse order, then flipped at the end
        StringBuilder binaryResult = new StringBuilder();

        int i = firstString.Length - 1; // Pointer for string firstString, starting from the end
        int j = secondString.Length - 1; // Pointer for string secondString, starting from the end
        int carry = 0; // To handle carryover when adding bits

        // Process both strings from right to left (least significant bit first)
        while (i >= 0 || j >= 0 || carry > 0) //this ends when we have decremented i and j past 0 and there's nothing else to carry
        {
            int sum = carry; // Start with any carried value
            Console.WriteLine($"Carry: " + sum); //added these to help me visualize

            // Add digit from string firstString if available
            if (i >= 0)
            {
                sum += firstString[i] - '0'; // Convert char because ASCII '0' value is 48 so if the string is 0 we subtract 48 from 48
                                             // if the value is '1' (this is 49 in ASCII) and 49-48 = 1 as an int
                i--;
                Console.WriteLine($"i: " + sum);
            }

            // Add digit from string secondString if available
            if (j >= 0)
            {
                sum += secondString[j] - '0'; // Convert char '0'/'1' to integer 0/1
                j--;
                Console.WriteLine($"j: " + sum);
            }

            // Append the least significant bit of sum to result
            // By appending, we're adding the digit to the right side, not the left side. So the result is going to be in reverse order
            binaryResult.Append(sum % 2); //this adds only a 0 or 1  
            Console.WriteLine($"Binary Result: " + binaryResult);

            // Update carry for next iteration
            carry = sum / 2; //this will keep the loop going when we run out of values but still have a carry digit
        }

        // Reverse the result since we built it backwards
        char[] charArray = binaryResult.ToString().ToCharArray();
        Array.Reverse(charArray);
        Console.WriteLine(string.Join("", charArray));
        return new string(charArray);
    }
}