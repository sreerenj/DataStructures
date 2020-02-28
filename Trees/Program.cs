using System;

namespace Trees
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a tree

            Tree tree = new Tree();
            for(int i =2;i<=11;i++)
            {
                tree.AddNode(i);
            }
            
        }
    }


}
