using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkList
{
    class LList
    {
        Node _firstNode;

        public Node getFirst()
        {
            return _firstNode;
        }

        public Node insertAfter(Node node, Node newNode)
        {
            newNode.next = node.next; // setze beim Neuen den Nächsten auf das was vorher der Nächste war
            node.next = newNode; // setze beim bisherigen Node den next auf den neu eingefügten
            return newNode;
        }
        public Node setFirst(Node first)
        {
            _firstNode = first;
            return _firstNode;
        }

        public void insertBeginning(Node newNode)
        {
            newNode.next = _firstNode.next;
            _firstNode = newNode;
        }

        public void insertEnd(Node newNode)
        {
            Node aktNode = _firstNode;

            while (aktNode.next != null)
                aktNode = aktNode.next;

            aktNode.next = newNode;
        }

        public Node getNodeWithData(int i)
        {
            Node aktNode = _firstNode;

            while (aktNode.next != null)
            {
                if (aktNode.data == i)
                    return aktNode;
                aktNode = aktNode.next;
            }
            return null;
        }

    }

    class Node
    {
        private int _data;
        public int data
        {
            get { return _data; }
            set { _data = value; }
        }

        private Node _next;
        public Node next
        {
            get { return _next; }
            set { _next = value; }
        }



        public Node(int i)
        {
            _data = i;
        }
    }
}
