using System;
using System.Collections.Generic;

namespace Trees
{
    class Node
    {
        public Node Left {get;set;}
        public int Data{get;set;}
        public Node Right{get;set;}

        public Node(int data)
        {
            Left = Right = null;
            Data = data;
        }
    }

    class Tree
    {
        Node _root;
        public Node Root
        {
            get{ return _root;}
        }
        
        public Tree()
        {
            _root = new Node(1);
        }

        public void AddNode(int data)
        {
            Node newNode = new Node(data);

            Node currentNode = _root;
            Queue<Node> qNodes = new Queue<Node>();
            while(currentNode != null)
            {
                if(currentNode.Left == null)
                {
                    currentNode.Left = newNode;
                    return;
                }
                else
                {
                    qNodes.Enqueue(currentNode.Left);
                }

                if(currentNode.Right == null)
                {
                    currentNode.Right = newNode;
                    return;
                }
                else
                {
                    qNodes.Enqueue(currentNode.Right);
                }
                currentNode = qNodes.Dequeue();
            }
        }
    }
}