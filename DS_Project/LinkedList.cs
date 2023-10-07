using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Project
{
	// Node class
	public class Node
	{
		public int element;
		public Node next;
        public Node(int e, Node n)
        {
			element = e;
			next = n;
        }
    }
	public class LinkedList
	{
		private Node Head;
		private Node Tail;
		private int Size;
        public LinkedList()
        {
			Head = null;
			Tail = null;
			Size = 0;
        }

		public int Lenght()
		{
			return Size;
		}
		public bool isEmpty()
		{
			return Size == 0;
		}


		public void AddLast(int e)
		{
			Node newest = new Node(e, null);
			if (isEmpty())
			{
				Head = newest;
			}
			else
			{
				Tail.next = newest;
			}
			Tail = newest;
			Size = Size + 1;
		}

		public void AddFirst(int e)
		{
			Node newest = new Node(e, null);
			if (isEmpty()) 
			{
				Head = newest;
				Tail = newest;
			}
			else
			{
				newest.next = Head;
				Head = newest;

			}
			Size = Size + 1;
		}

		public void AddAny(int e,int po)
		{
			if(po==0 || po >= Size)
			{
				Console.Write("Invaild position");
				return;
			}
			Node p = Head;
			Node newest = new Node(e, null);
			int i = 1;
			while (i < po - 1)
			{
				p = p.next;
				i = i + 1;
			}
			newest.next = p.next;
			p.next = newest;
			Size = Size + 1;
		}

		public void RemoveFirst()
		{
			if (Head != null)
			{
				Head = Head.next;
				Size = Size - 1;
			}
		}

		public void RemoveLast()
		{
			if (isEmpty())
			{
				Console.Write("List is empty");
			}
			Node p = Head;
			int i = 1;
			while (i < Size - 1)
			{
				p = p.next;
				i++;
			}
			Tail = p;
			Tail.next = null;
			Size--;
		}

		public void RemoveAny(int po)
		{
			if (isEmpty())
			{
				Console.Write("List is empty");
			}
			Node p = Head;
			int i = 1;
			while (i < po - 1)
			{
				p = p.next;
				i++;
			}
			p.next = p.next.next;
			Size--;

		}
		public void Display()
		{
			Node p = Head;
			while (p != null)
			{
				Console.WriteLine(p.element + "----->");
				p = p.next;
				Size = Size + 1;
			}
		}



    }
}
