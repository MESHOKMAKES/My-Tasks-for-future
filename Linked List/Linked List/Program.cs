using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Linked_List
{
    class Node
    {
        public int val;
        public Node next;
        public Node(int val)
        {
            this.val = val;
            next = null;
        }
    }
    class LinkedList
    {
        Node head;
        public LinkedList()
        {
            head = null;
        }
        public void AddLast(Node n)
        {
            if (head == null)
            {
                head = n;
                return;
            }
            Node cur = head;
            while (cur.next != null) 
                cur = cur.next;
            cur.next = n;
        }
        public bool Exist(Node n)
        {
            Node cur = head;
            while (cur.next != null)
            {
                if (cur.val == n.val)
                    return true;
                cur = cur.next;
            }
            return false;
        }
        public int Len()
        {
            if (head == null)
                return 0;
            Node cur = head;
            int element = 0;
            while(cur.next != null)
            {
                element++;
                cur = cur.next;
            }
            element++;
            return element;
        }
        public void AddFirst(Node n)
        {
            n.next = head;
            head = n;
        }
        public void AddAfter(Node nodeAfter, Node nodeTo)
        {
            Node cur = head;
            if (Exist(nodeAfter) == false)
                return;
            while (cur.val != nodeAfter.val && cur.next != null)
                cur = cur.next;
            Node tmp = cur.next;
            cur.next = nodeTo;
            cur.next.next = tmp;
        }
        public void Print()
        {
            if (head == null)
                return;
            Node cur = head;
            while (true)
            {
                Console.WriteLine(cur.val);
                if (cur.next == null)
                    break;
                cur = cur.next;
            }
        }
        public int FindByVaL(Node n)
        {
            if (head == null)
                return 0;
            Node cur = head;
            int firstPosition = 0;
            while(cur.val != n.val && cur.next != null)
            {
                cur = cur.next;
                firstPosition++;
            }
            return firstPosition;
        }
        public string FindAllByVal(Node n)
        {
            string str = "";
            if (head == null)
                return str;
            Node cur = head;
            for (int i = 0; i < Len(); i++)
            {
                if (cur.val == n.val)
                    str += i + " ";
                cur = cur.next;
            }
            return str;
        }
        public void Clear()
        {
            head = null;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
