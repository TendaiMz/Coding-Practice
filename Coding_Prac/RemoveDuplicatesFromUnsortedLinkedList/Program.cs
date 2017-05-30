using System;
using System.Collections;

namespace RemoveDuplicatesFromUnsortedLinkedList
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
            Node node6 = new Node();
            Node node7 = new Node();
            Node node8 = new Node();
            Node node9 = new Node();
            nodeOne.SetData(1);
            nodeOne.SetNext(nodeTwo);
            nodeTwo.SetData(2);
            nodeTwo.SetNext(nodeThree);
            nodeThree.SetData(3);
            nodeThree.SetNext(nodeFour);
            nodeFour.SetData(4);
            nodeFour.SetNext(nodeFive);
            nodeFive.SetData(5);
            nodeFive.SetNext(node6);
            node6.SetData(4);
            node6.SetNext(node7);
            node7.SetData(3);
            node7.SetNext(node8);
            node8.SetData(6);
            node8.SetNext(node9);
            node9.SetData(7);

            LnkdList linkedList = new LnkdList();
            linkedList.PrintNodes(nodeOne);
            Console.WriteLine(" Press any key to remove Duplicates");
            linkedList.RemoveDuplicates(nodeOne);



        }
    }

    class Node
    {

        int data;
        Node next;

        public int GetData()
        {
            return this.data;
        }

        public void SetData(int d)
        {
            this.data = d;
        }

        public Node GetNext()
        {
            return this.next;
        }

        public void SetNext(Node nxt)
        {
            this.next = nxt;
        }
    }

    class LnkdList
    {
        Node head;
        Hashtable hashTbl = new Hashtable();
        public LnkdList(Node head)
        {
            this.head = head;
        }

        public LnkdList()
        {
        }

        public void RemoveDuplicates(Node header)
        {
            this.head = header;
            while (head != null)
            {
                if (!hashTbl.Contains(head.GetData()))
                {
                    hashTbl.Add(head.GetData(), header);
                }
                head = head.GetNext();
            }
            foreach (DictionaryEntry entry in hashTbl)
            {
                Console.WriteLine(entry.Key);
            }
            Console.ReadKey();

        }

        public void PrintNodes(Node hdr)
        {
            while (hdr != null)
            {
                Console.WriteLine(hdr.GetData());
                hdr = hdr.GetNext();
            }
            Console.ReadKey();
        }

    }


}
