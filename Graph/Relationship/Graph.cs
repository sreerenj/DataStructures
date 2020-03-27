using System;
using System.Collections.Generic;

public class Node
{
    public char Data{get;set;}
    public List<Node> Nodes;

    public Node(char data)
    {
        Data = data;
        Nodes = new List<Node>();
    }
}

public class Graph
{
    public void SetData(char data, char relation)
    {
        
    }
}