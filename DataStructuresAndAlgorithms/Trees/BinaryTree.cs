using System;
namespace Trees
{

    public class BinaryTree
    {
        public readonly Node Root;

        public BinaryTree(Node root)
        {

            this.Root = root;
        }

        public void PrintValues()
        {
            PrintTreeValues(this.Root);
        }

        private void PrintTreeValues(Node node)
        {


            if (node == null)
            {
                return;
            }

            Console.WriteLine(node.Data);
            PrintTreeValues(node.LeftNode);
            PrintTreeValues(node.RightNode);
        }


    }


}