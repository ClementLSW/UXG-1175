using System;


partial class Program {
    static void Insert<K, V>(ref Node<K, V> root, K key, V val) where K : IComparable<K> {
        Node<K, V> node = new Node<K, V>(key, val);

        if (root == null) {
            root = node;
            return;
        }

        // If provided key is smaller than root key
        if (key.CompareTo(root.key) < 0) {
            Insert<K, V>(ref root.left, key, val);
        }
        else if (key.CompareTo(root.key) > 0) {
            Insert<K, V>(ref root.right, key, val);
        }

        return;
    }

    static bool Search<K, V>(Node<K, V> root, K keyToSearch, ref V valOutput) where K : IComparable<K> {
        // TODO
        if (root == null) {
            return false;
        }
        else if (keyToSearch.CompareTo(root.key) != 0) {
            //Console.Write("_Debug_: NodeKey: {0}, KeyToSearch: {1}\n", root.key, keyToSearch);
            if (keyToSearch.CompareTo(root.key) > 0) {
                return Search(root.right, keyToSearch, ref valOutput);
            }
            else if (keyToSearch.CompareTo(root.key) < 0) {
                return Search(root.left, keyToSearch, ref valOutput);
            }
        }
        else{
            valOutput = root.val;
            return true;
        }

        return false;
    }
    static void Modify<K, V>(Node<K, V> root, K keyToSearch, V newValue) where K : IComparable<K> {
        // TODO
        if (root == null) {
            return;
        }

        if (keyToSearch.CompareTo(root.key) > 0) {
            Modify(root.right, keyToSearch, newValue);
        }
        else if (keyToSearch.CompareTo(root.key) < 0) {
            Modify(root.left, keyToSearch, newValue);
        }
        else {
            root.val = newValue;
        }
    }

    static void PrintPreOrder<K, V>(Node<K, V> root) where K : IComparable<K> {
        // TODO
        if (root == null) {
            return;
        }
        else {
            Console.Write("[{0} = {1}]", root.key, root.val);
            PrintPreOrder(root.left);
            PrintPreOrder(root.right);
        }
    }

    static void PrintPostOrder<K, V>(Node<K, V> root) where K : IComparable<K> {
        // TODO
        if (root == null) {
            return;
        }
        else {
            PrintPostOrder(root.left);
            PrintPostOrder(root.right);
            Console.Write("[{0} = {1}]", root.key, root.val);
        }
    }
}
