namespace LinkedList
{
    public class Node
    {
        public Node(int data)
        {

            this.Data = data;
        }
        public readonly int Data;
        
        private Node nextNode;
        public Node NextNode
        {
            get { return nextNode; }
            set { nextNode = value; }
        }
    }
}