using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    static class Program
    {
        private static void Main(string[] args)
        {
            var node = new Link_ls();
            node.Push(1);
            node.Push(2);
            node.Push(3);
            node.Push(4);
            node.Push(7);
            node.ListNodes();
            Console.ReadKey();
        }
    }
 
}