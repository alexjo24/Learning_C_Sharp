using System;
using System.Collections;
using System.Collections.Generic;

public class Queue<T> : IEnumerable{

    // Instantiate a linkedlist to store the queue elements in.
    private LinkedList<T> list = new LinkedList<T>();

    // Instantiate an array to store the elements from the queue in to use for "foreach" functionality.
    private T[] storeElements;

    public Queue()
    {
        Console.WriteLine("Queue initialized \n");
        
    }

    // Enqueue method adds elements to the queue.
    public void Enqueue(T data){

        list.AddFirst(data);

    }

    // Count method returns an int with the number of elements in the queue.
    public int Count(){
        return list.Count;
    }

    //Clear method clears the queue from elements.
    public void Clear(){
        list.Clear();
    }

    // Dequeue method removes the element in the beginning of the queue and returns it.
    public T Dequeue(){
        T data = list.Last.Value;
        list.RemoveLast();
        return data;
    }

    // Peek method returns the first element in the queue.
    public T Peek(){
        return list.Last.Value;
    }

    // ToArray method is only used in the Queue class and hence it is private. The method is used for "foreach functionality"
    // 1. Instantiate a new T[] array with the size of the queue.
    // 2. Copy the linkedlist elements to the array.
    // 3. Since the elements are in the "wrong" order according to the order of the queue to be displayed to the user, reverse the array.
    private void ToArray(){
        storeElements = new T[Count()];
        list.CopyTo(storeElements, 0);
        Array.Reverse(storeElements);
    }

    // Foreach functionality implemented.
    public IEnumerator GetEnumerator()
    {
        ToArray();
        return storeElements.GetEnumerator();
    }
}