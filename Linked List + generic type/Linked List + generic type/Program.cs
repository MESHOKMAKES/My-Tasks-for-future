using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List___generic_type
{
  
    public class LinkedList<T>
    {
        public class Node 
        {
            public T val;
            public Node next;
            public Node(T val)
            {
                this.val = val;
                next = null;
            }
            public string ToString()
            {
                return val.ToString();
            }
        }

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
            if (IComparable.ReferenceEquals(tail, n))
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
        public bool RemoveAllByVal(T n)
        {
            if (head == null)
                return false;
            Node cur = head;
            for (int i = 0; i < len; i++)
            {
                if (IEquatable<T>.Equals(head.val, n))
                {
                    Remove(head);
                    cur = head;
                }
                if (IEquatable<T>.Equals(cur.val, n))
                {
                    Remove(cur);
                }
            }
            return true;
        }
        public void AddLast(T n)
        {
            Node node = new Node(n);
            if (head == null)
            {
                AddToHead(node);
                return;
            }
            Node cur = tail;
            cur.next = node;
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
        public void AddFirst(T n)
        {
            Node node = new Node(n);
            if (head == null)
            {
                AddToHead(node);
                return;
            }
            node.next = head;
            head = node;
            len++;
        }
        public bool AddAfter(Node nodeAfter, T nodeTo)
        {
            if (!Exist(nodeAfter))
                return false;
            Node nodeNext = new Node(nodeTo);
            Node cur = nodeAfter;
            Node tmp = cur.next;
            cur.next = nodeNext;
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
        public Node FindByVaL(T n)
        {
            if (head == null)
                return null;
            Node cur = head;
            while (!IEquatable<T>.Equals(cur.val, n) && cur.next != null)
                cur = cur.next;
            return cur;
        }
        public LinkedList<T> FindAllByVal(T n)
        {
            if (head == null)
                return null;
            LinkedList<T> linkedList = new LinkedList<T>();
            Node cur = head;
            for (int i = 0; i < len; i++)
            {
                
                if (IEquatable<T>.Equals(cur.val, n))
                    linkedList.AddLast(cur.val);
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
