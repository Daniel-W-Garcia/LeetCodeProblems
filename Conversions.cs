namespace LeetCodeProblems;

public class Conversions
{
    public int RomanToInt(string inputString)
    {
        //Roman numeral are written in a specific manner. Usually largest to smallest.
        //However, if a smaller value preceeds a larger value, the smaller value is subtracted from the larger value.
        Dictionary<char, int> romanValues = new Dictionary<char, int> //dictionary of values
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };
    
        int totalValue = 0;
    
        for (int i = 0; i < inputString.Length; i++) //iterate over the string
        {
            int currentValue = romanValues[inputString[i]]; // Get current symbol value
        
            
            if (i + 1 < inputString.Length) // Check if there is a next symbol
            {
                int nextValue = romanValues[inputString[i + 1]];// assign next symbol value to temp variable to check against current value
            
                // If current value is less than next value, subtract current from result
                if (currentValue < nextValue)
                {
                    totalValue += (nextValue - currentValue);//subtacts the small value from the large value then adds it to the result
                    i++; // now we skip the larger symbol since it's already been added to the result
                    continue;
                }
            }
        
            // Add the current value to result
            totalValue += currentValue;
        }
        return totalValue;
    }
    public int RomanToInt2(string s) 
    {
        int count = 0;
        for (int i = 0; i < s.Length; i++)
        {
            //this one is really clever as it will iterate i twice by use of the continue keyword
            //when a condition is met it will add the appropriate value ('IV' = 4), iterate to the next character and restart the loop
            //the keyword continue halts the checking of further conditions and moves to the next iteration of the loop/restarts the loop
            //so since the condition iterates AND the loop iterates, i is incremented twice so it moves to the next appropriate character
            if (i + 1 < s.Length)
            {
                if (s[i] == 'I' && s[i + 1] == 'V') { count += 4; i++; continue; } 
                if (s[i] == 'I' && s[i + 1] == 'X') { count += 9; i++; continue; }
                if (s[i] == 'X' && s[i + 1] == 'L') { count += 40; i++; continue; }
                if (s[i] == 'X' && s[i + 1] == 'C') { count += 90; i++; continue; }
                if (s[i] == 'C' && s[i + 1] == 'D') { count += 400; i++; continue; }
                if (s[i] == 'C' && s[i + 1] == 'M') { count += 900; i++; continue; }
            }
            
            //if none of the above conditions are met, that means we don't need to do and subtraction and can just add the value directly
            //since roman numerals are written from largest to smallest, this logic will work
            if (s[i] == 'I') { count += 1; continue; }
            if (s[i] == 'V') { count += 5; continue; }
            if (s[i] == 'X') { count += 10; continue; }
            if (s[i] == 'L') { count += 50; continue; }
            if (s[i] == 'C') { count += 100; continue; }
            if (s[i] == 'D') { count += 500; continue; }
            if (s[i] == 'M') { count += 1000; continue; }
        }
        return count;
    }
    public int RomanToInt3(string s) 
    {
        // this one is the most intuitive to me.
        // starts with the last character and works backwards and just subtracts the value from the total
        Dictionary<char,int> RomanMap = new Dictionary<char,int>
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };
        int prevValue=0;
        int total=0;
        for(int i=s.Length-1; i>=0; i--)
        {
            int currentValue=RomanMap[s[i]];
            if(currentValue<prevValue)
            {
                total-=currentValue;
            }
            else
            {
                total+=currentValue;
            }
            prevValue=currentValue;
        }
        return total;
    }
}