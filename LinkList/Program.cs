using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkList
{
    class Program
    {
        static void Main(string[] args)
        {
            LList l1 = new LList();
            Node first = l1.setFirst(new Node(7));
            Node second = l1.insertAfter(first, new Node(12));
            Node third = l1.insertAfter(second, new Node(28));


            LList l2 = new LList();
            Node node = l2.setFirst(new Node(7));
            for (int i = 0; i < 20; i++)
            {
                node = l2.insertAfter(node, new Node(node.data + 2));
            }

            node = l2.getFirst();
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(node.data);
                node = node.next;
            }

            Node foundNode = l2.getNodeWithData(17);

            Console.WriteLine("gefunden: " + foundNode.data + " und nächster: " + foundNode.next.data);

            Console.ReadKey();

        }
    }
    
}
