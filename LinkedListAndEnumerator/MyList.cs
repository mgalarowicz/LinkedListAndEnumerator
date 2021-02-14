namespace LinkedListAndEnumerator
{
    public class MyList
    {
        public Node headNode;

        public MyList()
        {
            headNode = null;
        }

        public void AddToBeginning(int data)
        {
            if (headNode == null)
                headNode = new Node(data);
            else
            {
                Node tmp = new Node(data);
                tmp.next = headNode;
                headNode = tmp;
            }
        }

        public void AddSorted(int data)
        {
            if (headNode == null)
                headNode = new Node(data);
            else if (data < headNode.data)
                AddToBeginning(data);
            else
                headNode.AddSorted(data);
        }

        public void AddToEnd(int data)
        {
            if (headNode == null)
            {
                headNode = new Node(data);
            }
            else
            {
                headNode.AddToEnd(data);
            }
        }
        
        public void Print()
        {
            if (headNode != null)
            {
                headNode.Print();
            }
        }
    }
}