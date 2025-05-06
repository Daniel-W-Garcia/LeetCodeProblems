namespace LeetCodeProblems;

public class Palindromes
{
    public bool IsPalindrome(int x)
    {
        string stringToTest = x.ToString(); //convert the number to a string because it's easier
        for (int i = 0; i < stringToTest.Length / 2; i++) //loop through half the string since we are checking from both ends
        {
            if (stringToTest[i] != stringToTest[stringToTest.Length - i - 1])// compare the first and last characters then work inward
            {
                return false;
            }
        }
        return true;    
    }
    public bool IsPalindrome2(int intToTest) //this one is neat but hard to understand for me
    {
        // Negative numbers can't be palindromes
        if (intToTest < 0)
            return false;
        
        // Special case: single digit numbers are always palindromes
        if (intToTest >= 0 && intToTest < 10)
            return true;
        
        // If number ends with 0, it can't be a palindrome unless it's 0 itself
        if (intToTest % 10 == 0 && intToTest != 0)
            return false;
    
        int reversed = 0; 
        int original = intToTest;
    
        // Reverse the integer gonna use 121 to track what's happening
        while (intToTest > 0) // runs 3 times until the 3rd loop when intToTest = 0
        {
            int digit = intToTest % 10; // first loop: intToTest = 121 % 10 so digit is 1
                                // second loop: intToTest = 12 % 10 so digit is 2
                                // third loop: intToTest = 1 % 10 so digit is 1
                        
            reversed = reversed * 10 + digit; // first loop: 0 * 10 + 1 = 1
                                              // second loop: 1 * 10 + 2 = 12
                                              // third loop: 12 * 10 + 1 = 121
                                            
            intToTest /= 10; // first loop: 121 / 10 = 12
                     // second loop: 12 / 10 = 1
                     // third loop: 1 / 10 = 0
        }

        return original == reversed; // this only runs when the above loop is complete
                                     // first loop: original = 121, reversed = 1 so wouldn't have been true
                                     // second loop: original = 121, reversed = so wouldn't have been true
                                     // third loop: original = 121, reversed = 121 so this will run and return true
    }
    public bool IsPalindrome3(int x) // same as above but only reverses half the numbers
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