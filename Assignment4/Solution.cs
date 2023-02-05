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
        // If end of tree
        if (root == null) {
            return false;                                   // Return False; i.e. to say: no such entry
        }
        else if (keyToSearch.CompareTo(root.key) != 0) {    // If current root key is not result we are looking for
            //Console.Write("_Debug_: NodeKey: {0}, KeyToSearch: {1}\n", root.key, keyToSearch);
            if (keyToSearch.CompareTo(root.key) > 0) {      // If result we want is bigger than current root key, search right branch
                return Search(root.right, keyToSearch, ref valOutput);
            }
            else if (keyToSearch.CompareTo(root.key) < 0) { // If result we want is smaller than current root key, search left branch
                return Search(root.left, keyToSearch, ref valOutput);
            }
        }
        else{                                               // If current root key is the answer
            valOutput = root.val;                           // Set ref ValOutput to associated value
            return true;                                    // Return true to denote result found
        }

        return false;                                       // Catch-all Return False [Should not ever reach here]
    }
    static void Modify<K, V>(Node<K, V> root, K keyToSearch, V newValue) where K : IComparable<K> {
        // If cannot find required key, just return
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
        // If end of tree
        if (root == null) {
            return;
        }
        else {
            Console.Write("[{0} = {1}]", root.key, root.val);       // Step 1: Visit Node
            PrintPreOrder(root.left);                               // Step 2: Visit left branch
            PrintPreOrder(root.right);                              // Step 3: Visit right branch
        }
    }

    static void PrintPostOrder<K, V>(Node<K, V> root) where K : IComparable<K> {
        // If end of tree
        if (root == null) {
            return;
        }
        else {
            PrintPostOrder(root.left);                              // Step 1: Visit left branch
            PrintPostOrder(root.right);                             // Step 2: Visit right branch
            Console.Write("[{0} = {1}]", root.key, root.val);       // Step 3: Visit node
        }
    }
}
