namespace LinkedList
{
    public class ReverseListRecursive : IExecutable
    {
        Node Start;

        public void Do()
        {
            LinkedList newList = new LinkedList();
            newList.CreateList();
            newList.ViewLinkedList();
        }
    }
}