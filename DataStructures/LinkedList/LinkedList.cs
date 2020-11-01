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

    // Count the number of nodes in the linkedlist. 
    // If the list is empty return 0,otherwise return number of nodes.
    public int Count(){

        Node<T> currentNode = head;
        int cc = 0;

        //Check if the linkedlist is empty
        //If the list is empty, tell the user that the list is empty.
        //Otherwise, loop over the list starting from the head.
        if (head == null){
            Console.WriteLine("The linkedlist is empty.");    
        }else{
            while (currentNode != null){

                // Traverse the list by updating currentNode with a pointer to the next node.
                currentNode = currentNode.next;
                cc ++;

            }
        }
        return cc;
    }
    /// <summary>
    /// Obtain the first node in the linkedlist.
    /// ".data" can be used for obtaining node data.
    /// e.g. YourLinkedList.First().data --> return of type T, node data.
    ///</summary>
    public Node<T> First(){
        return head;
    }

    /// <summary>
    /// Obtain the last node in the linkedlist.
    /// ".data" can be used for obtaining node data.
    /// e.g. YourLinkedList.Last().data --> return of type T, node data.
    ///</summary>
    public Node<T> Last(){
        return tail;
    }

    // Find and returns the first node found with the specfied data.
    // Returns null if no node with the specified data is found.
    public Node<T> Find(T data){
        Node<T> currentNode = head;

        Node<T> nodeFound = null;

        //Check if the linkedlist is empty
        //If the list is empty, tell the user that the list is empty.
        //Otherwise, loop over the list starting from the head.
        if (head == null){
            Console.WriteLine("The linkedlist is empty.");    
        }else{
            while (currentNode != null && nodeFound == null){
                
                // Compare if input data is equal to current node data in the loop. Compares generic types.
                if (currentNode.data.Equals(data)){
                    nodeFound = currentNode;
                }

                // Traverse the list by updating currentNode with a pointer to the next node.
                currentNode = currentNode.next;


            }
         }
         return nodeFound;
    }

    // Remove the first node found with the specified data.
    // Returns true if the node with the specified data is removed, otherwise false.
    public bool Remove(T data){

        Node<T> currentNode = head;
        Node<T> previousNode = head;

        bool nodeFound = false;

        //Check if the linkedlist is empty
        //If the list is empty, tell the user that the list is empty.
        //Otherwise, loop over the list starting from the head.
        if (head == null){
            Console.WriteLine("The linkedlist is empty.");    
        }else{
            while (currentNode != null && nodeFound == false){
                
                // Compare if input data is equal to current node data in the loop. Compares generic types.
                if (currentNode.data.Equals(data)){
                    nodeFound = true;

                    // Check if the node in the loop is the first node in the linkedlist to be removed.
                    // Point head towards next node instead of current
                    // Otherwise set pointer for previous Node to point towards the next node, relative to the current node.
                    if (currentNode.Equals(head)){
                        head = currentNode.next;
                    }else{
                        previousNode.next = currentNode.next;
                    }
                    

                }

                // Traverse the list by updating currentNode with a pointer to the next node.
                previousNode = currentNode;
                currentNode = currentNode.next;
                


            }
         }
         return nodeFound;
    }


}