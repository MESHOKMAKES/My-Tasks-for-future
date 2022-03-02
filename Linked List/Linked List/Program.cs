using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Linked_List
{
    public class Node
    {
        public int val;
        public Node next;
        public Node(int val)
        {
            this.val = val;
            next = null;
        }
        public string ToString()
        {
            return val.ToString();
        }
    }
    public class LinkedList
    {
        public Node head;
        public Node tail;
        public int len;
        
        public LinkedList()
        {
            tail = null;
            head = tail;
        }
        void AddToHead(Node n)
        {
            tail = n;
            head = tail;
            len++;
        }
        public Node Search(int pos)
        {
            if (len < pos || head == null)
                return null;
            else
            {
                Node cur = head;
                int i = 0;
                while (true)
                {
                    if (i == pos)
                        return cur;
                    if (cur.next == null)
                        return null;
                    cur = cur.next;
                    i++;
                }
            }
        }
        public bool Remove(Node n)
        {
            if (!Exist(n))
                return false;
            Node cur = head;
            if (IComparable.ReferenceEquals(head, n))
            {
                head = cur.next;
                len--;
                return true;
            }
            if(IComparable.ReferenceEquals(tail, n))
            {
                while (cur.next != tail)
                    cur = cur.next;
                tail = cur;
                tail.next = null;
                len--;
                return true;
            }
            while (cur.next != n)
                cur = cur.next;
            cur.next = cur.next.next;
            len--;
            return true;
        }
        public bool RemoveAllByVal(int n)
        {
            if(head == null)
                return false;
            Node cur = head;
            for(int i = 0; i < len; i++)
            {
                if(head.val == n)
                {
                    Remove(head);
                    cur = head;
                }
                if(cur.val == n)
                {
                    Remove(cur);
                }
            }
            return true;
        }
        public void AddLast(Node n)
        {
            if (head == null)
            {
                AddToHead(n);
                return;
            }
            Node cur = tail;
            cur.next = n;
            tail = cur.next;
            len++;
        }
        public bool Exist(Node n)
        {
            if (head == null)
                return false;
            if (IComparable.ReferenceEquals(tail, n))
                return true;
            if (IComparable.ReferenceEquals(head, n))
                return true;
            Node cur = head;
            while (cur.next != null)
            {

                if (IComparable.ReferenceEquals(cur, n))
                    return true;
                cur = cur.next;
            }
            return false;
        }
        public void AddFirst(Node n)
        {
            if (head == null)
            {
                AddToHead(n);
                return;
            }
            n.next = head;
            head = n;
            len++;
        }
        public bool AddAfter(Node nodeAfter, Node nodeTo)
        {
            if (!Exist(nodeAfter))
                return false;
            Node cur = nodeAfter;
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
            while (cur.val != n && cur.next != null)
                cur = cur.next;
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
                    linkedList.AddLast(new Node(cur.val));
                cur = cur.next;
            }
            return linkedList;
        }
        public void Clear()
        {
            tail = null;
            head = tail;
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
