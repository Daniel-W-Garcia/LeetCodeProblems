namespace LeetCodeProblems;

public class Palindromes
{
    public bool IsPalindrome(int x)
    {
        string stringToTest = x.ToString();
        for (int i = 0; i < stringToTest.Length / 2; i++)
        {
            if (stringToTest[i] != stringToTest[stringToTest.Length - i - 1])
            {
                return false;
            }
        }
        return true;    
    }
    public bool IsPalindrome2(int x) 
    {
        // Negative numbers can't be palindromes
        if (x < 0)
            return false;
        
        // Special case: single digit numbers are always palindromes
        if (x >= 0 && x < 10)
            return true;
        
        // If number ends with 0, it can't be a palindrome unless it's 0 itself
        if (x % 10 == 0 && x != 0)
            return false;
    
        int reversed = 0;
        int original = x;
    
        // Reverse the integer
        while (x > 0) 
        {
            int digit = x % 10;
            reversed = reversed * 10 + digit;
            x /= 10;
        }
    
        return original == reversed;
    }
    public bool IsPalindrome3(int x) 
    {
        // Negative numbers can't be palindromes
        if (x < 0)
            return false;
        
        // If number ends with 0, it can't be a palindrome unless it's 0 itself
        if (x % 10 == 0 && x != 0)
            return false;
    
        int reversed = 0;
    
        // Only reverse half the number
        while (x > reversed) 
        {
            reversed = reversed * 10 + x % 10;
            x /= 10;
        }
    
        // For odd length numbers, the middle digit doesn't matter
        // so we can remove it with reversed / 10
        return x == reversed || x == reversed / 10;
    }
}