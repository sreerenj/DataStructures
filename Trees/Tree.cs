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
        Node root;
        Queue<Node> qNodes = new Queue<Node>();
        public Tree()
        {
            root = new Node(1);
        }

        public void AddNode(Node node, int data)
        {
            qNodes.Enqueue(node);
            if(node.Left == null)
            {
                node.Left = new Node(data);
                return;
            }
            qNodes.Enqueue(node.Left);
            if(node.Right == null)
            {
                node.Right = new Node(data);
                return;
            }

        }
    }
}