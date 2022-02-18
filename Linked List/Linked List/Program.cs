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
        Node tail;
        int len;
        public LinkedList()
        {
            tail = null;
            head = tail;
        }
        public void AddLast(Node n)
        {
            if (head == null)
            {
                tail = n;
                head = tail;
                len++;
                return;
            }
            Node cur = tail;
            cur.next = n;
            tail = cur.next;
            len++;
        }
        public Node Exist(Node n)
        {
            Node cur = head;
            while (cur.next != null)
            {
                if (cur.val == n.val)
                    return cur;
                cur = cur.next;
            }
            return null;
        }
        public void AddFirst(Node n)
        {
            n.next = head;
            head = n;
            len++;
        }
        public bool AddAfter(Node nodeAfter, Node nodeTo)
        {
            if (Exist(nodeAfter) == null)
                return false;
            Node cur = Exist(nodeAfter);
            Node tmp = cur.next;
            cur.next = nodeTo;
            cur.next.next = tmp;
            len++;
            return true;
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
        public Node FindByVaL(int n)
        {
            if (head == null)
                return null;
            Node cur = head;
            int firstPosition = 0;
            while (cur.val != n && cur.next != null)
            {
                cur = cur.next;
                firstPosition++;
            }
            return cur;
        }
        public LinkedList FindAllByVal(int n)
        {
            if (head == null)
                return null;
            LinkedList linkedList = new LinkedList();
            Node cur = head;
            for (int i = 0; i < len; i++)
            {
                if (cur.val == n)
                    linkedList.AddLast(cur);
                cur = cur.next;
            }
            return linkedList;
        }
        public void Clear()
        {
            head = null;
            len = 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
