using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinkedList
{
    public class Node
    {
        public int data;
        public Node next;
    }

    public class MySingleLinkedList
    {
        public Node head;

        public string Display()
        {
            string result = "";

            Node current = new Node();
            current = head;         // We will start from 1st Node and check all the Nodes

            while (current != null)
            {
                result = result + " --> " + current.data;
                current = current.next;
            }
            return result;
        }

        public void AddLast(int value)
        {
            if (head == null)
            {
                head = new Node();
                head.data = value;          //Here we are saving the HEAD and it will be SAVED for later time also
            }
            else
            {
                Node newNode = new Node();
                newNode.data = value;

                Node current = new Node();
                current = head;

                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = newNode;     // We need to pass a NODE not just DATA
            }
        }

        public void AddFirst(int value)
        {
            Node newNode = new Node();
            newNode.data = value;
            newNode.next = head;

            head = newNode;     //NEW NODE is the starting point now
        }

        public void AddBefore(int findValue,int value)
        {
            Node newNode = new Node();
            newNode.data = value;

            // TEMP NODE for saving the previous Node as we can't go backward (Like Doublely Linked List)
            Node tempPreviousNode = new Node();

            Node current = new Node();
            current = head;

            while (current != null)
            {
                if (findValue == current.data)
                {
                    newNode.next = current;
                    tempPreviousNode.next = newNode;
                }
                else
                {
                    tempPreviousNode = current;
                }
                current = current.next;
            }
        }

        public void AddAfter(int findValue, int value)
        {
            Node newNode = new Node();
            newNode.data = value;

            Node current = new Node();
            current = head;

            while (current != null)
            {
                if (current.data == findValue)
                {
                    newNode.next= current.next;
                    current.next = newNode;
                }
                current = current.next;                
            }
        }
    }
}
