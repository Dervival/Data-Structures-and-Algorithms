# C# Stacks and Queues
Stacks and queues are a pair of linear data structures. A stack acts in a first-in, last-out way; the only accessible member for all actions, the Top, is the last added element (so the first added element is the last to be removed). The queue acts in a first-in, first-out way; the only accessible member of the structure, the Front, is the first added element, while newly added nodes are appended to the rear.

## Challenge
- Create a Node class that has properties for the value stored in the Node, and a pointer to the next node.
- Create a Stack class that has a top property. It creates an empty Stack when instantiated.
- This object should be aware of a default empty value assigned to top when the stack is created.
- Define a method called push for the Stack class which takes any value as an argument and adds a new node with that value to the top of the stack with an O(1) Time performance.
- Define a method called pop for the Stack class that does not take any argument, removes the node from the top of the stack, and returns the node’s value.
- Define a method called peek that does not take an argument and returns the value of the node located on the top of the stack.
- Create a Queue class that has a front and rear property. It cannot be instantiated without an initial value.
- Define a method called enqueue which takes any value as an argument and adds a new node with that value to the back of the queue with an O(1) Time performance.
- Define a method called dequeue that does not take any argument, removes the node from the front of the queue, and returns the node’s value.
- Define a method called peek that does not take an argument and returns the value of the node located in the front of the stack.


## API, Approach & Efficiency
Stack
- Push: Adds a node to the top of the stack. Void return type. The node can either be created in the process or directly passed in. O(1) space and time impact, as no iteration is needed to push a new object and only one node is being pushed at a time.
- Pop: Removes and returns the top node of the stack. Node return type. If the stack is empty, throws a null exception error (so peeking is suggested before popping). O(1) space and time impact, as no iteration is required and only one node is returned regardless of the height of the stack.
- Peek: Returns the top node of the stack. Node return type. If the stack is empty, returns null. O(1) space and time impact, similar to pop.

Queue
- Enqueue: Adds a node to the rear of the queue. Void return type. The node can either be created in the process or directly passed in. O(1) space and time impact, as no iteration is needed to enqueue a new object and only one node is being enqueued at a time.
- Dequeue: Removes and returns the Front node of the stack. Node return type. If the stack is empty, throws a null exception error (so peeking is suggested before dequeueing). O(1) space and time impact, as no iteration is required and only one node is returned regardless of the height of the stack.
- Peek: Returns the Front node of the stack. Node return type. If the stack is empty, returns null. O(1) space and time impact, similar to pop.
