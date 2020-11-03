using System;
using System.Collections;

public class Stack<T> : IEnumerator, IEnumerable{

    //Instantiate a counter to keep track of the size of the stack.
    private int cc;

    //Instantiate an empty array, used to store stack data.
    private T[] arr = new T[0];

    //Instantiate a position tracker for the IEnumerator/IEnumerable fuctionality.
    int position = -1;

    private T[] copyArr;
    public Stack()
    {
        Console.WriteLine("Stack initialized \n");
        cc = -1;
    }

    // Push method adds one element to the stack.
    // Resizes the array to make space for a new element containing generic type data. 
    public void Push(T data){

        Array.Resize(ref arr, arr.Length+1);

        arr[++cc] = data ;

    }

    // Pop method shrinks the stack in size by 1.
    // Returns the removed element.
    public T Pop(){
        T item = arr[cc--];
        Array.Resize(ref arr, arr.Length-1);
        return item;
    }

    // Peek method lets the user observe the top element in the stack.
    // Return the top element in the stack.
    public T Peek(){
        return arr[cc];
    }

    // Count method counts the number of elements in the stack.
    // Returns the size of the stack.
    public int Count(){
        return arr.Length;
    }

    // Clear method removes all elements in the stack --> Empty Stack
    public void Clear(){
        cc = -1;
        Array.Resize(ref arr, 0);
    }

    // reverseArray method is used for "for each" loop functionality. 
    // The method reverses the array
    private T[] reverseArray(){
        copyArr = new T[arr.Length];
        Array.Copy(arr , 0,copyArr,0 , arr.Length);
        Array.Reverse(copyArr);                     // O(n) operation
        return copyArr;
    }


    // Added functionality to use foreach loops in the code below
    // --> Copied from https://docs.microsoft.com/en-us/troubleshoot/dotnet/csharp/make-class-foreach-statement
    // Both IEnumerator and IEnumerable are required for the use of foreach

    //IEnumerator and IEnumerable require these methods.
    public IEnumerator GetEnumerator(){
        return (IEnumerator)this;
    }

    //IEnumerator
    public bool MoveNext()
    {
        reverseArray();
        position++;
        return (position < copyArr.Length);
    }
    //IEnumerable
    public void Reset()
    {
        position = 0;
    }
    //IEnumerable
    public object Current
    {
        get { return copyArr[position];}
    }


}

