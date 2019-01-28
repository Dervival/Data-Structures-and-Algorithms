# C# Trees
Trees are a category of data structures that consist of a root node and their children. Each node in a tree has up to one parent; all non-root nodes in a tree must have one and only one parent. Children nodes may have children of their own. A node with no children is considered to be a leaf node.
In this implementation, we will focus on binary trees and binary search trees. Binary trees allow nodes to have up to two children, a left child and a right child. No sort of ordering or logic is required in this structure. Binary search trees are a special subcategory of binary trees whose nodes must be sorted - that is, a parent node must have a greater value than its left child node, if it exists, and a equal or lesser value than its right child node, if it exists.

## Challenge
- Create a Node class that has properties for the value stored in the node, the left child node, and the right child node.
- Create a BinaryTree class
	-- Define a method for each of the depth first traversals called preOrder, inOrder, and postOrder which returns an array of the values, ordered appropriately.
	-- At no time should an exception or stack trace be shown to the end user. Catch and handle any such exceptions and return a printed value or operation which cleanly represents the state and either stops execution cleanly, or provides the user with clear direction and output.

- Create a BinarySearchTree class
	-- Define a method named add that accepts a value, and adds a new node with that value in the correct location in the binary search tree.	
	-- Define a method named contains that accepts a value, and returns a boolean indicating whether or not the value is in the tree at least once.
	-- At no time should an exception or stack trace be shown to the end user. Catch and handle any such exceptions and return a printed value or operation which cleanly represents the state and either stops execution cleanly, or provides the user with clear direction and output.


## API, Approach & Efficiency
Binary Tree:
- Pre-order traversal: Traverses a tree in pre-order order recursively - the root node is evaluated first, then all nodes in the subtree whose root is the left child of the current root, then all nodes in the subtree whose root is the right child of the current root. When evaluating nodes in subtrees, the same method is called on the targeted child. Returns a list of values of the visited nodes, in order of how they were visited. Big O Time impact: O(n) // Space impact: O(h) (on the call stack) and O(n) (for creating the list of values). We need to visit all nodes during this traversal and each visit takes at least O(1), so we cannot achieve anything better than O(n) time impact. Recursively calling this function means that another instance of the method is placed on the call stack - the maximum height of the call stack will be O(h), where h is the longest path from the root node to a leaf node. Since we are generating a list to capture the visited values, we require O(n) for that list; if we were capturing the values in some other way that required no additional space (for instance, printing to the console), this portion of the algorithm would devolve to O(1) for an overall space impact of O(h).

- In-order traversal: Traverses a tree in-order recursively -  all nodes in the subtree whose root is the left child of the current root are evaluated, then the root node is evaluated, then all nodes in the subtree whose root is the right child of the current root. When evaluating nodes in subtrees, the same method is called on the targeted child. Returns a list of values of the visited nodes, in order of how they were visited. Big O Time and space impact are identical to pre-order traversal.

- Post-order traversal: Traverses a tree post-order recursively -  all nodes in the subtree whose root is the left child of the current root are evaluated, then all nodes in the subtree whose root is the right child of the original root node, then the root node is evaluated. When evaluating nodes in subtrees, the same method is called on the targeted child. Returns a list of values of the visited nodes, in order of how they were visited. Big O Time and space impact are identical to pre-order and in-order traversal.


Binary Search Tree:
- Add: adds an integer value to the binary search tree while maintaining the property that all children and descendants to the left of the root node of a BST have values that are less than that of the root node, and all children and descendants to the right of the root of a BST have equal or greater values than the root node. No return type. Big O Time impact: O(log(n)) // Space impact: O(1). Because we have an ordered binary search tree, each traversal/check covers double the nodes than the previous check did - that is, doubling the number of nodes (assuming a reasonably balanced tree...) will result in only one or two more checks, which implies a growth of O(log(n)). We only generate a new node and a boolean in this process regardless of the size of the tree, since no recursion is used, giving us constant space impact.

- Contains: Determines whether or not an integer exists in the given tree; if so, returns true, if not, returns false. Big O Time impact: O(log(n)) // Space impact: O(1). Similar to the add functionality, we can leverage the fact that there is some internal sorted structure to require only one check on every level of the tree, resulting in O(log(n)) space impact. We only generate a new node and a boolean in this process regardless of the size of the tree as no recursion is used, giving us constant space impact.
