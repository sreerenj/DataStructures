using System;
using System.Collections.Generic;
using System.Linq;
namespace Graph
{
    public class Node<T>
    {
        public T Data
        {
            get;
            set;
        }
        public List<Node<T>> Nodes;

        public Node(T data)
        {
            Data = data;
            Nodes = new List<Node<T>>();
        }
    }

    public class Graph<T>
    {
        List<Node<T>> Nodes = new List<Node<T>>();
        public void AddNode(T data)
        {
            if(!Nodes.Any(x => object.Equals(x.Data, data)))
            {
                Node<T> node = new Node<T>(data);
                Nodes.Add(node);
            }
        }
        
        public void AddEdge(T data, T linkData)
        {
            Node<T> node = GetNode(data);
            Node<T> linkNode = GetNode(linkData);
            if(node!=null && linkNode != null)
            {
                node.Nodes.Add(linkNode);
            }
        }

        public Node<T> GetNode(T data)
        {
            return Nodes.First(x => object.Equals(x.Data, data));
        }
        public void ListNodes()
        {
            foreach(Node<T> node in Nodes)
            {
                Console.Write(node.Data);
                foreach(Node<T> subNode in node.Nodes)
                {
                    Console.Write("=>" + subNode.Data);
                }
                Console.WriteLine();
            }
        }
    }
}
