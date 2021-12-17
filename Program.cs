using System;
using System.Collections.Generic;
class linkedlist
{
    static void Main(string[] args)
    {
        LinkedList<string> name = new LinkedList<string>();
        name.AddFirst("akmalhusain");
        name.AddFirst("shakib");
        name.AddFirst("sharukh");
        name.AddFirst("ajmal");
        name.AddLast("aayat");
        Console.WriteLine("before remove the linkedlist\n");
        foreach (string names in name)
        {
            Console.WriteLine(names);
        }
        name.RemoveFirst();
        name.RemoveLast();  
        Console.WriteLine("\n"+"after remove the linkedlist\n");
        foreach(string names in name)
        {
            Console.WriteLine(names);
        }
       Console.WriteLine("\n"+"use after and before node\n ");
        LinkedListNode<string> Node =  name.Find("akmalhusain");
        name.AddBefore(Node, "sadiya");
        name.AddAfter(Node, "foziya");
        foreach (string i in name)
        { 
            Console.WriteLine(i);
        }



        

    }
}
