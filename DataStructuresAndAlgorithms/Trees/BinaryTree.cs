using System;
using System.Collections.Generic;
namespace Trees
{

    public class BinaryTree
    {
        public readonly Node Root;

        public BinaryTree(Node root)
        {

            this.Root = root;
        }

        public void TraverseDepthFirst()
        {
            DepthFirstTravesal(this.Root);
        }

        public void TraverseBreathFirst()
        {
            BreathFirstTravesal(this.Root);
        }


        private void DepthFirstTravesal(Node node)
        {


            if (node == null)
            {
                return;
            }

            Console.Write(node.Data);
            DepthFirstTravesal(node.LeftNode);
            DepthFirstTravesal(node.RightNode);
        }

        private void BreathFirstTravesal(Node node)
        {
            if (node == null) return;

            var queue = new Queue<Node>();

            queue.Enqueue(node);
            while (queue.Count > 0)
            {
               var current = queue.Dequeue();              
               Console.Write(current.Data);
               

               if(current.LeftNode!=null){
                   queue.Enqueue(current.LeftNode);
               }

               if(current.RightNode!=null){
                   queue.Enqueue(current.RightNode);
               }

            }

        }


    }


}