namespace LeetCodeProblems;

public class Solutions
{
    Dictionary<int, int> dictionaryToEvaluate = new Dictionary<int, int>(); //create a dicitonary to hold duplicates
    public int SingleNumber(int[] nums) 
    {
        foreach(int item in nums)
        {
            if (dictionaryToEvaluate.ContainsKey(item)) //check if the dictionary contains the item
            {
                dictionaryToEvaluate[item]++; //if it does increment the value by 1 for that item
            }
            else
            {
                dictionaryToEvaluate.Add(item, 1); //if it doesn't add the item to the dictionary with a value of 1
            }
        }

        foreach (var pair in dictionaryToEvaluate) //look at the kvps in the dictionary
        {
            if (pair.Value == 1) // if an item has a value of 1
            {
                return pair.Key; //return the item. this gives us all unique items in the arra
            }
        }
        return -1;
    }

    public void FizzBuzz(int num)
    {
        for (int i = 1; i <= num; i++)
        {
            if (num % 3 == 0 && num % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }

            if (num % 3 == 0 && num % 5 != 0)
            {
                Console.WriteLine("Fizz");
            }
            if (num % 3 != 0 && num % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(num);
            }
        }
    }
    
}