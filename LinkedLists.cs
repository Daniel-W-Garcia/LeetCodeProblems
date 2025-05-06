namespace LeetCodeProblems;

public class LinkedLists
{
    public static void MakeLinkedList()  
    {

      // Create a new LinkedListNode of type String and displays its properties.
      LinkedListNode<String> linkedListNode = new LinkedListNode<String>( "orange" );
      Console.WriteLine( "After creating the node ...." );
      DisplayProperties( linkedListNode );

      // Create a new LinkedList.
      LinkedList<String> linkedList = new LinkedList<String>();

      // Add the "orange" node and display its properties.
      linkedList.AddLast( linkedListNode );
      Console.WriteLine( "After adding the node to the empty LinkedList ...." );
      DisplayProperties( linkedListNode );

      // Add nodes before and after the "orange" node and display the "orange" node's properties.
      linkedList.AddFirst( "red" );
      linkedList.AddLast( "yellow" );
      Console.WriteLine( "After adding red and yellow ...." );
      DisplayProperties( linkedListNode );
   }

   public static void DisplayProperties( LinkedListNode<String> linkedListNode )  
   {
      if ( linkedListNode.List == null )
         Console.WriteLine( "   Node is not linked." );
      else
         Console.WriteLine( "   Node belongs to a linked list with {0} elements.", linkedListNode.List.Count );

      if ( linkedListNode.Previous == null )
         Console.WriteLine( "   Previous node is null." );
      else
         Console.WriteLine( "   Value of previous node: {0}", linkedListNode.Previous.Value );

      Console.WriteLine( "   Value of current node:  {0}", linkedListNode.Value );

      if ( linkedListNode.Next == null )
         Console.WriteLine( "   Next node is null." );
      else
         Console.WriteLine( "   Value of next node:     {0}", linkedListNode.Next.Value );

      Console.WriteLine();
   }
}


/*

This code produces the following output.

After creating the node ....
   Node is not linked.
   Previous node is null.
   Value of current node:  orange
   Next node is null.

After adding the node to the empty LinkedList ....
   Node belongs to a linked list with 1 elements.
   Previous node is null.
   Value of current node:  orange
   Next node is null.

After adding red and yellow ....
   Node belongs to a linked list with 3 elements.
   Value of previous node: red
   Value of current node:  orange
   Value of next node:     yellow

*/