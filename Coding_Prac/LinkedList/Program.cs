using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            //traversing a linked list

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

            Node test = new Node();
            test = nodeOne;
            while (test!=null)
            {
                Console.WriteLine(test.GetData());
                test= test.GetNext();

            }
            Console.ReadKey();
        }

        class Node {
            int data { get; set; }
            Node next { get; set; }
            public Node(int data)
            {
                this.data = data;                
               
            }

            public Node()
            {
            }

            public void SetData(int data)
            {
                this.data = data;
            }
            public int GetData() {
                return this.data;
            }

            public void SetNext(Node next) {
                this.next = next;
            }

            public Node GetNext() {
                return this.next;
            }
        }
    }
}
