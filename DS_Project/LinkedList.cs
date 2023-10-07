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
