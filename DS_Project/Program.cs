

// See https://aka.ms/new-console-template for more information

using DS_Project;

LinkedList l = new LinkedList();
l.AddLast(7);
l.AddLast(3);
l.AddLast(4);
l.AddLast(5);
l.AddFirst(1);
//l.RemoveLast();
////l.AddAny(22, 2);
//l.RemoveFirst();
l.RemoveAny(3);
l.Display();
Console.ReadKey();
