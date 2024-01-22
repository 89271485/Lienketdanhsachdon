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
        public void DeleteHead()
        {
            if (Head != null)
            {
                Node P = Head;
                Head = Head.Next;
                P.Next = null;
            }
        }
        public void DeleteLast()
        {
            if (Head != null)
            {
                Node p = Head;
                Node q = null;
                while (p.Next != null)
                {
                    q = p;
                    p = p.Next;
                }
                q.Next = null;
            }
        }
        public void Deletenode(int x)
        {
            if (Head != null)
            {
                Node p = Head;
                Node q = null;
                while (p != null && p.Info != x)
                {
                    q = p;
                    p = p.Next;
                }
                if (p != null)
                {
                    if (p == Head)
                        DeleteHead();
                    else
                    {
                        q.Next = p.Next;
                        p.Next = null;
                    }
                }
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
        public Node findMax()
        {
            Node max = Head;
            Node p = Head.Next;
            while (p != null)
            {
                if (p.Info > max.Info)
                {
                    max = p;
                }
                p = p.Next;
            }
            return max;
        }
        public float Avg()
        {
            float sum = 0;
            int count = 0;
            Node p = Head;
            while (p != null)
            {
                sum += p.Info;
                count++;

                p = p.Next;
            }
            return sum / count;
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



            ds.DeleteHead();
            Console.WriteLine("\nDanh sach lien ket sau khi xoa nut dau:");
            ds.ProcessList();


            ds.DeleteHead();
            Console.WriteLine("\nDanh sach sau khi xoa nut cuoi:");
            ds.ProcessList();

            Console.Write("\nNhap gia x can xoa:");
            int x = int.Parse(Console.ReadLine());
            ds.Deletenode(x);
            Console.WriteLine("\nDanh sach lien ket sau khi xoa nut cos gia tri x:");
            ds.ProcessList();

            Console.WriteLine($"\nGia tri nut lon nhat :{ds.findMax().Info}");
            Console.WriteLine($"\nGia tri trung cua danh sach : {ds.Avg()}");
            Console.ReadLine();
        }
        static void NhapDanhSach(SingleLinkList ds)
        {
            string chon = "y";
            int x;
            while (chon != "n")
            {
                Console.Write("Nhap gia tri nut:");
                x = int.Parse(Console.ReadLine());
                ds.AddLast(x);
                Console.Write("Tiep tuc (y/n)?");
                chon = Console.ReadLine();

            }
        }
    }
}
