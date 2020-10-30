using System;

//Generic class LinkedList<T>
public class LinkedList<T>
{

    public Node<T> tail;
    public Node<T> head;


    public LinkedList()
    {
        Console.WriteLine("LinkedList initialized");
        
    }

    // Adds a node to the start of the list.
    public void AddFirst(T data){
        Node<T> nodeFirst = new Node<T>(data);

        // Checking if the linkedlist is empty
        if (head == null){
            // If the list is empty, point the head and the tail to the new node.
            head = nodeFirst;
            tail = nodeFirst;
        }else{
            // If the list is not empty, point node.next to the current head and point the head to the newly added node.
            
            nodeFirst.next = head;
            head = nodeFirst;
            
            

        }
    }

    // Adds a node to the end of the list.
    public void AddLast(T data){
        Node<T> nodeLast = new Node<T>(data);

        // Checking if the linkedlist is empty
        if (head == null){
            // If the list is empty, point the head and the tail to the new node.
            head = nodeLast;
            tail = nodeLast;
        }else{
            // If the list is not empty, point next and the tail to the new node.
            tail.next = nodeLast;
            tail = nodeLast;
        }
    }

    public void ShowNodes(){

        Node<T> currentNode = head;

        //Check if the linkedlist is empty
        //If the list is empty, tell the user that the list is empty.
        //Otherwise, loop over the list starting from the head.
        if (head == null){
            Console.WriteLine("The linkedlist is empty.");    
        }else{
            Console.Write("Node data: ");
            while (currentNode != null){

                // Writes the data of each node to the Console/Terminal,
                // starting from the head and moving back in the list until there are no more nodes.
                if(currentNode.next != null){
                    Console.Write(currentNode.data + ", ");
                }else{
                    Console.Write(currentNode.data);
                    Console.WriteLine();
                }
                

                // Traverse the list by updating currentNode with a pointer to the next node.
                currentNode = currentNode.next;
            }
        }


    }


    public int Count(){

        Node<T> currentNode = head;
        int cc = 0;

        if (head == null){
            Console.WriteLine("The linkedlist is empty.");    
        }else{
            Console.Write("Node data: ");
            while (currentNode != null){

                // Traverse the list by updating currentNode with a pointer to the next node.
                currentNode = currentNode.next;
                cc ++;

            }
        }
        return cc;
    }

    public Node<T> First(){
        Node<T> firstNode = head;
        return firstNode;
    }

    public Node<T> Last(){
        Node<T> lastNode = tail;
        return lastNode;
    }


}