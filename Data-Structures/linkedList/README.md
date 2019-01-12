# C# Singly Linked List
The Linked List is one of the simplest data structures. It consists of a group of nodes that each contain a values and a reference to the next node in the list. The linked list also contains a reference to the head of itself as well as a running reference for traversals.

## Challenge
- Create a Node class that has properties for the value stored in the Node, and a pointer to the next Node.
- Within your LinkedList class, include a head property. Upon instantiation, an empty Linked List should be created.
- This object should be aware of a default empty value assigned to head when the linked list is instantiated.
- Define a method called insert which takes any value as an argument and adds a new node with that value to the head of the list with an O(1) Time performance.
- Define a method called includes which takes any value as an argument and returns a boolean result depending on whether that value exists as a Node’s value somewhere within the list.
- Define a method called print which takes in no arguments and outputs all of the current Node values in the Linked List.

## API, Approach & Efficiency
- Insert: Inserts a node at the head of the list. The node can be created in the process or passed in. O(1) space and time impact.
- Includes: Determines if a value exists within the linked list. O(n) time and O(1) space impact, where n is the number of nodes in the list. 
- Print: Prints out all elements of the linked list to the console. O(n) time and O(1) space impact, where n is the number of nodes in the list.
- CountNodes: Returns the number of nodes in the linked list. If the list is empty, returns zero. O(n) time and O(1) space impact, where n is the number of nodes in the list.
- Behead: Removes the first node from the linked list if the list is not empty. 0(1) time and space impact.
