namespace LeetCodeProblems;

public static class ScratchPaper
{
    private static LinkedListNode<String> linkedListNode = new LinkedListNode<string>("Orange");
    
    public static void PrintLinkedList()
    {
        Console.WriteLine("After creating the node.....");
        Console.WriteLine(linkedListNode.Value);
    }
}