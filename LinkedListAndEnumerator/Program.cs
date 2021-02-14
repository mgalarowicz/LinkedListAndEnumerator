namespace LinkedListAndEnumerator
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList list = new MyList();
            //list.AddToEnd(10);
            //list.AddToEnd(5);
            //list.AddToBeginning(11);
            //list.AddToEnd(6);
            //list.AddToEnd(7);
            list.AddSorted(10);
            list.AddSorted(5);
            list.AddSorted(11);
            list.AddSorted(6);
            list.AddSorted(7);
            list.Print();
        }
    }
}
