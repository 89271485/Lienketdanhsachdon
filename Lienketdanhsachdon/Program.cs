using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lienketdanhsachdon
{
 class Node
    {
        private int info;
        private Node next;
        public Node(int x)
        {
            info = x;
            next = null;

        }
        public int Info
        {
            set { this.info = value; }
            get { return info; }

        }
        public Node Next
        {
            set { this.next = value; } 
            get { return next; }
        }

    }
    class SingleLinkList
    {
        private Node Head;
        public SingleLinkList()
        {
            Head = null;

        }
        public void AddHead(int x)
        {
            Node p = new Node(x);
            p.Next = Head;
            Head = p;

        }
        public void AddLast(int x)
        {
            Node p = new Node(x);
            if  (Head == null)
            {
                Head = p;
            }
            else
            {
                Node q = Head;
                while (p.Next != null)
                {
                    q = q.Next;
                }
                p.Next = q;
            }

        }
        public void ProcessList()
        {
            Node p = Head;
            while ( p != null)
            {
                Console.Write($"{p.Info} ");
                p = p.Next;
            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SingleLinkList ds = new SingleLinkList();
            ds.AddHead(9);
            ds.AddHead(6);
            ds.AddHead(5);
            ds.AddHead(7);
            Console.WriteLine("Danh sach lien ket :");
            ds.ProcessList();
            Console.ReadLine();
        }
    }
}
