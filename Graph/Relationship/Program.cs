using System;
using Graph;

namespace Relationship
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph<char> graph = new Graph<char>();
            graph.AddNode('A');
            graph.AddNode('B');
            graph.AddNode('C');
            graph.AddNode('D');
            graph.AddNode('E');
            graph.AddNode('F');
            graph.AddNode('G');
            graph.AddNode('H');
            graph.AddNode('I');
            graph.AddNode('J');
            graph.AddNode('K');

            graph.AddEdge('A', 'B');
            graph.AddEdge('A', 'C');
            graph.AddEdge('B', 'C');
            graph.AddEdge('B', 'E');
            graph.AddEdge('D', 'E');
            graph.AddEdge('D', 'A');
            graph.AddEdge('I', 'K');
            graph.AddEdge('J', 'K');
            graph.AddEdge('G', 'H');
            graph.AddEdge('E', 'F');
            graph.AddEdge('F', 'G');
            graph.AddEdge('D', 'K');

            graph.ListNodes();
        }
    }
}
