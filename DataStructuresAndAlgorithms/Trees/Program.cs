using System;

namespace Trees
{
    class Program
    {
        static void Main(string[] args)
        {

            var tree = BuildTree();
            Console.WriteLine("Traverse tree");
            Console.WriteLine("Depth First");
            tree.TraverseDepthFirst();
            Console.WriteLine(" ");
            Console.WriteLine("Breath First");          
            tree.TraverseBreathFirst();
            Console.WriteLine(" ");

        }


        private static BinaryTree BuildTree()
        {
            Node nodeOne = new Node(1);
            Node nodeTwo = new Node(2);
            Node nodeThree = new Node(3);
            Node nodeFour = new Node(4);
            Node nodeFive = new Node(5);
            Node nodeSix = new Node(6);
            Node nodeSeven = new Node(7);
            Node nodeEight = new Node(8);
            Node nodeNine = new Node(9);

            nodeOne.LeftNode = nodeTwo;
            nodeOne.RightNode = nodeThree;

            nodeTwo.LeftNode = nodeFour;
            nodeTwo.RightNode = nodeFive;

            nodeThree.LeftNode = nodeSix;
            nodeThree.RightNode = nodeSeven;

            nodeFour.LeftNode = nodeEight;

            nodeFive.RightNode = nodeNine;

            return new BinaryTree(nodeOne);

        }


    }
}
