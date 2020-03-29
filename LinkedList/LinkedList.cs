using System;
namespace LinkedList
{
    public class LinkedList
    {
        Node Start = null;
        public void CreateList()
        {
            for(int i = 1 ;i <= 10;i++)
            {
                AddNodeAtBeginning(i);
            }
        }

        public void AddNodeAtBeginning(int data)
        {
            Node newNode = new Node(data);
            if(Start == null)
            {
                Start = newNode;
                return;
            }
            newNode.Next = Start;
            Start = newNode;
        }

        public void AddNodeAtEnd(int data)
        {
            Node newNode = new Node(data);
            if(Start == null)
            {
                Start = newNode;
                return;
            }
            Node tempNode = Start;
            while(tempNode.Next != null)
            {
                tempNode = tempNode.Next;
            }


        }
        public void ViewLinkedList()
        {
            Node tempNode = Start;
            while(tempNode!=null)
            {
                Console.Write(tempNode.Data);
                if(tempNode.Next != null)
                {
                    Console.Write( " -> ");
                }
                else
                {
                    Console.Write(" -> NULL");
                }
                tempNode = tempNode.Next;
            }
        }
    }
}