namespace LinkedList
{
    public class LinkedList
    {
        public LinkedList(Node head)
        {

            this.Head = head;
        }

        public Node Head { get; private set; }

        public void PrintAllNodesValues()
        {
            System.Console.WriteLine("Generating LinkedList Values");
            var node = this.Head;
            
            while (node!=null)
            {
                System.Console.WriteLine($"The node value is {node.Data}");                
                node=node.NextNode;
            }

        }


         public void PrintAllValues(Node node)
        {
            // StringBuilder str = new StringBuilder("");
            // string st = new string();
            


            if (node==null)
            {
                return;
            }
            
            System.Console.WriteLine($"The node value is {node.Data}"); 
            PrintAllValues(node.NextNode);   

        }
    }


}