using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_Add_Delete_Node
{
    class Program
    {
        static void Main(string[] args)
        {
            Node nodeOne = new Node();
            Node nodeTwo = new Node() { };
            Node nodeThree = new Node() { };
            Node nodeFour = new Node() { };
            Node nodeFive = new Node() { };
            nodeOne.SetData(1);
            nodeOne.SetNext(nodeTwo);
            nodeTwo.SetData(2);
            nodeTwo.SetNext(nodeThree);
            nodeThree.SetData(3);
            nodeThree.SetNext(nodeFour);
            nodeFour.SetData(4);
            nodeFour.SetNext(nodeFive);
            nodeFive.SetData(5);
            SinglyLinkedList linkedList = new SinglyLinkedList(nodeOne);
           // linkedList.PrintNodes();
            Console.WriteLine("After node 3 is deleted");
            linkedList.DeleteNode(nodeOne,nodeTwo);
            linkedList.PrintNodes();
           

        }
    }

    class Node
    {
        public int data { get; set; }
        public Node next { get; set; }

        public Node(int d)
        {
            this.data = d;
        }

        public Node()
        {
        }

        public int GetData()
        {
            return this.data;
        }

        public void SetData(int d)
        {
            this.data = d;
        }

        public void SetNext(Node n)
        {
            this.next = n;

        }
        public Node GetNext()
        {
            return this.next;
        }

      
    }

    class SinglyLinkedList
    {
        Node head;
        public SinglyLinkedList(Node h)
        {
            this.head = h;
        }

        public void PrintNodes()
        {
            while (head !=null)
            {
                Console.WriteLine(head.data);
                head = head.GetNext();
            }
            Console.ReadKey();
        }

        public Node DeleteNode(Node head,Node n)
        {
            Node headNode = head;
           
            while (head != null)
            {
                if (head.next == n)
                {
                    head.next = n.next;
                    return headNode;
                }
                else
                {
                    head = head.next;
                }
                
            }
            return headNode;
        }

        //public void AddNode(Node newNode,Node )
        //{
        //    while (this.head != null)
        //    {
        //        if (head != null)
        //        {

        //        }
        //        else
        //        {

        //        }

        //    }


        //}
    }
}
