using System;

class Node<T> {
    public T item;
    public Node<T> next;

    public Node(T item) {
        this.item = item; 
        this.next = null;
    }
}

partial class Program {

    static void PrintLinkedList<T>(Node<T> head) {
        Console.Write("Printing Linked List: "); 
        while (head != null) {
            Console.Write("{0} ", head.item);
            head = head.next;
        }
        Console.WriteLine();
    }

    static void Main() {
        { 
            Console.WriteLine("== Testing AddFirst");
            Node<int> head = null;
            for (int i = 0 ; i < 10; ++i) {
                AddFirst(ref head, i * 10);
                PrintLinkedList(head);
            }
        }


        
        {
            Console.WriteLine("== Testing AddList");
            Node<int> head = null;
            for (int i = 0 ; i < 10 ; ++i) {
                AddLast(ref head, i * 10);
                PrintLinkedList(head);
            }
        }
      
        {

            Console.WriteLine("== Testing RemoveFirst");
            Node<int> head = null;
            for (int i = 0 ; i < 10 ; ++i) {
                AddLast(ref head, i * 10);
            }
            PrintLinkedList(head);
            while(head != null) {
                RemoveFirst(ref head);
                PrintLinkedList(head);
            }


        }
        {

            Console.WriteLine("== Testing RemoveLast");
            Node<int> head = null;
            for (int i = 0 ; i < 10 ; ++i) {
                AddLast(ref head, i * 10);
            }
            PrintLinkedList(head);
            while(head != null) {
                RemoveLast(ref head);
                PrintLinkedList(head);
            }


        }

        
        {
            Console.WriteLine("== Testing Count");
            Node<int> head = null;
            for (int i = 0 ; i < 10 ; ++i) {
                AddLast(ref head, i * 10);
                PrintLinkedList(head);
                Console.WriteLine("Current Count: {0}", Count(head));
            }
 
        }

        {
            Console.WriteLine("== Testing ToArray");
            Node<int> head = null;
            for (int i = 0 ; i < 10 ; ++i) {
                AddLast(ref head, i * 10);
                PrintLinkedList(head);

                int[] arr = ToArray(head);
                Console.Write("Printing Array: ");
                foreach(int e in arr) {
                    Console.Write("{0} ", e);
                }
                Console.WriteLine();
            }
         }

    }
}
