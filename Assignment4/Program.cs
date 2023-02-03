using System;




class Node<K,V> where K : IComparable<K> {
    public K key;
    public V val;

    public Node<K,V> left;
    public Node<K,V> right;

    public Node(K k, V v) {
        key = k;
        val = v;
        left = null;
        right = null;
    }
}

partial class Program {

    static void PrintInOrder<K,V>(Node<K,V> root) where K : IComparable<K>
    {
        if (root == null) {
          return;
        }
        PrintInOrder(root.left);
        Console.Write("[{0} = {1}]", root.key, root.val);
        PrintInOrder(root.right);
    }
    
    static void WrapSearch(Node <string,string> root, string key) {
        string test = null;
        if (Search(root, key, ref test)){
            Console.WriteLine("Found \"{0}\": \"{1}\"", key, test);    
        }
        else {
            Console.WriteLine("Cannot Find \"{0}\"", key); 
        }
       
    }
    
    

    static void TestPreOrder() {
        Console.WriteLine("=== Test PreOrder");
        Node<int, string> node = null;

        Insert(ref node, 5, "but");
        PrintPreOrder(node);
        Console.WriteLine();

        Insert(ref node, 1, "hard");
        PrintPreOrder(node);
        Console.WriteLine();

        Insert(ref node, 2, "is");
        PrintPreOrder(node);
        Console.WriteLine();

        Insert(ref node, 21, "break!");
        PrintPreOrder(node);
        Console.WriteLine();

        Insert(ref node, 3, "important");
        PrintPreOrder(node);
        Console.WriteLine();

        Insert(ref node, 10, "remember");
        PrintPreOrder(node);
        Console.WriteLine();

        Insert(ref node, 14, "take");
        PrintPreOrder(node);
        Console.WriteLine();

        Insert(ref node, 11, "to");
        PrintPreOrder(node);
        Console.WriteLine();
       
        Insert(ref node, 20, "a");
        PrintPreOrder(node);
        Console.WriteLine();

        Insert(ref node, -1, "studying");
        PrintPreOrder(node);
        Console.WriteLine();
       
        // Should not insert!
        Insert(ref node, 3, "again");
        PrintPreOrder(node);
        Console.WriteLine();



    }

    static void TestPostOrder() {
        Console.WriteLine("=== Test PostOrder");
        Node<int, string> node = null;

        Insert(ref node, 5, "but");
        PrintPostOrder(node);
        Console.WriteLine();

        Insert(ref node, 1, "hard");
        PrintPostOrder(node);
        Console.WriteLine();

        Insert(ref node, 2, "is");
        PrintPostOrder(node);
        Console.WriteLine();

        Insert(ref node, 21, "break!");
        PrintPostOrder(node);
        Console.WriteLine();

        Insert(ref node, 3, "important");
        PrintPostOrder(node);
        Console.WriteLine();

        Insert(ref node, 10, "remember");
        PrintPostOrder(node);
        Console.WriteLine();

        Insert(ref node, 14, "take");
        PrintPostOrder(node);
        Console.WriteLine();

        Insert(ref node, 11, "to");
        PrintPostOrder(node);
        Console.WriteLine();
       
        Insert(ref node, 20, "a");
        PrintPostOrder(node);
        Console.WriteLine();

        Insert(ref node, -1, "studying");
        PrintPostOrder(node);
        Console.WriteLine();
       
        // Should not insert!
        Insert(ref node, 3, "again");
        PrintPostOrder(node);
        Console.WriteLine();



    }

    static void TestInsert() {
        Console.WriteLine("=== Test Insert");
        Node<int, string> node = null;

        Insert(ref node, 5, "but");
        PrintInOrder(node);
        Console.WriteLine();

        Insert(ref node, 1, "hard");
        PrintInOrder(node);
        Console.WriteLine();

        Insert(ref node, 2, "is");
        PrintInOrder(node);
        Console.WriteLine();

        Insert(ref node, 21, "break!");
        PrintInOrder(node);
        Console.WriteLine();

        Insert(ref node, 3, "important");
        PrintInOrder(node);
        Console.WriteLine();

        Insert(ref node, 10, "remember");
        PrintInOrder(node);
        Console.WriteLine();

        Insert(ref node, 14, "take");
        PrintInOrder(node);
        Console.WriteLine();

        Insert(ref node, 11, "to");
        PrintInOrder(node);
        Console.WriteLine();
       

        Insert(ref node, 20, "a");
        PrintInOrder(node);
        Console.WriteLine();

        Insert(ref node, -1, "studying");
        PrintInOrder(node);
        Console.WriteLine();
       
        // Should not insert!
        Insert(ref node, 3, "again");
        PrintInOrder(node);
        Console.WriteLine();

    }


    static void TestSearch() {
        Console.WriteLine("=== Test Search");
        Node<string, string> node = null;
        
        WrapSearch(node, "apples");
        Insert(ref node, "apples", "cruncy with lots of fiber!");

        WrapSearch(node, "apples");
      
        Insert(ref node, "pear", "it's green...");
        Insert(ref node, "banana", "it is long and yellow!");
        Insert(ref node, "grapes", "they come in bunches!");
        Insert(ref node, "dragonfruit", "outside is pink, inside is white!");
        Insert(ref node, "strawberry", "many seeds outside!");


        WrapSearch(node, "pear");
        WrapSearch(node, "strawberry");
        WrapSearch(node, "cat");

        PrintInOrder(node);
        Console.WriteLine();

    }

    static void TestModify() {
        Console.WriteLine("=== Test Modify");
        Node<string, string> node = null;

        Insert(ref node, "apples", "crunchy with lots of fiber!");
        Insert(ref node, "pear", "it's green...");
        Insert(ref node, "banana", "it is long and yellow!");
        Insert(ref node, "grapes", "they come in bunches!");
        Insert(ref node, "dragonfruit", "outside is pink, inside is white!");
        Insert(ref node, "strawberry", "many seeds outside!");

        Console.Write("Unmodified: ");
        PrintInOrder(node);
        Console.WriteLine();


        Modify(node, "apples", "it is red");
        Modify(node, "pear", "it is green");
        Modify(node, "banana", "it is yellow");
        Modify(node, "grapes", "it is purple");
        Modify(node, "dragonfruit", "it is alot of colors");
        Modify(node, "cat", "it goes meow");

        Console.Write("Modified: ");
        PrintInOrder(node);
        Console.WriteLine();

    }

    static void Main() {

        TestInsert();
        Console.WriteLine();

        TestPreOrder();
        Console.WriteLine();

        TestPostOrder();
        Console.WriteLine();

        TestSearch();
        Console.WriteLine();

        TestModify();
        Console.WriteLine();
    }
}
