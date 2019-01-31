# Find max value of a binary tree
Further binary tree practice.

## Challenge
Given a binary tree (assuming integer values), return the largest value of the tree.

## Approach & Efficiency
1. Approach - This approach essentially uses a recursive post-order traversal of the tree to determine the maximum of a node's value, the maximum value of the subtree to the left, and the maximum value of the subtree to the right, and returns the largest of those three up the tree. 

2. Efficiency - Big O Time = O(n) // Big O Space = O(h) (where h is the height of the tree) - As we are traversing through all nodes of a tree (as a binary tree cannot guarantee any order or sorting of its nodes), we need to take an amount of time proportional to the number of nodes in the tree. Since we only do a couple of quick comparisons at each level once we've reached a base case of a leaf node, the time required devolves to a growth rate of no faster than O(n). This approach uses a recursive traversal of the tree, so h instances are added to the call stack at the bottom of the tree; we aren't instantiating anything outside of a couple of integer values at any given instance of the recursive function, so the space required grows no fast than a rate of O(h).

## Solution

![Whiteboard for Breadth-First Print](../../assets/binaryTreeMaxValue.jpg)

