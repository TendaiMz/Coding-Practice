using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
           System.Console.WriteLine("Having Fun with LinkedLits");
            var linkedList = GenerateLinkedList();
            linkedList.PrintAllNodesValues();
            
            System.Console.WriteLine("Generating LinkedLits values using recursion");
            linkedList.PrintAllValues(linkedList.Head);
        }

        private static LinkedList GenerateLinkedList(){
          Node nodeOne = new Node(1); 
          Node nodeTwo = new Node(2);  
          Node nodeThree = new Node(3);  
          Node nodeFour = new Node(4);  
          Node nodeFive = new Node(5); 
          nodeOne.NextNode=nodeTwo;
          nodeTwo.NextNode=nodeThree;
          nodeThree.NextNode=nodeFour;
          nodeFour.NextNode=nodeFive;
          nodeFive.NextNode=null;
          
          LinkedList linkedList = new LinkedList(nodeOne);
          return linkedList;
        }

    }
}