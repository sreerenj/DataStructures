using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            IExecutable executable = new ReverseListRecursive();
            executable.Do();
        }
    }
}
