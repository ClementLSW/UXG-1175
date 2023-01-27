using System;

partial class Program {

    static void AddFirst<T>(ref Node<T> head, T itemToInsert) {
        Node<T> newNode = new Node<T>(itemToInsert);
        newNode.next = null;
        if (head != null) {
            newNode.next = head;
            head = newNode;
        }
        else {
            head = newNode;
        }

        return;
    }

    static void AddLast<T>(ref Node<T> head, T itemToInsert) {
        Node<T> newNode = new Node<T>(itemToInsert);
        newNode.next = null;
        Node<T> iterator = head;
        if (head != null) {
            while(iterator.next != null) {
                iterator = iterator.next;                               // Iterates till the last element
            }
            iterator.next = newNode;
        }
        else {
            head = newNode;
        }

        return;
    }


    static void RemoveFirst<T>(ref Node<T> head) {
        if(head != null) {
            head = head.next;
        }
        return;             // head is null
    }


    // This one can be tricky. 
    // There are typically 3 cases you will have to look out for:
    // 1. When head is null.
    // 2. When there are exactly 1 item in the list.
    // 3. When there are more than 1 items in the list.
    static void RemoveLast<T>(ref Node<T> head) {
        //TODO
        if(head != null) {
            if(head.next != null) {                                     // Case 3. If not last element
                Node<T> iterator = head;
                while(iterator.next.next != null) {                     // Check if next Node is last
                    iterator = iterator.next;
                }
                iterator.next = null;                                   // Break Linkage
            }
            else {                                                      // Case 2: If head is already last element
                head = null;
            }
        }
        return;                                                         // Case 1: head is null
    }

    static int Count<T>(Node<T> head) {
        int count = 0;
        Node<T> i = head;

        while (i != null) {
            count++;
            i = i.next;
        }
        return count;
    }

    static T[] ToArray<T>(Node<T> head) 
    {
        Node<T> iterator = head;
        int index = 0;
        T[] arr = new T[Count<T>(head)];
        while (iterator != null) {
            arr[index] = iterator.item;
            iterator = iterator.next;
            index++;
        }

        return arr;
    }


}
