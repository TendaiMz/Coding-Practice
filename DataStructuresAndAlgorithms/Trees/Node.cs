
namespace Trees
{
    public class Node
    {

        public readonly int Data;
        public  Node(int data)
        {
            this.Data = data;
        }
     
        public Node LeftNode { get; set; } = null;
        public Node RightNode { get; set; } = null;

    }
}

