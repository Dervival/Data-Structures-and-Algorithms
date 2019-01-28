using System;
using System.Collections.Generic;
using System.Text;

namespace Tree.Classes
{
    public class BinarySearchTree : BinaryTree<int>
    {
        /// <summary>
        /// Default constructor for a BST - starts with a null root
        /// </summary>
        public BinarySearchTree()
        {

        }

        /// <summary>
        /// Constructor for a BST with an initially given value - generate the root node and assign it to the tree
        /// </summary>
        /// <param name="value">Value of the root node of the new tree.</param>
        public BinarySearchTree(int value)
        {
            Node<int> newNode = new Node<int>(value);
            this.Root = newNode;
        }

        /// <summary>
        /// Constructor for a BST with a given initial root node
        /// </summary>
        /// <param name="newNode">The root node of the new tree</param>
        public BinarySearchTree(Node<int> newNode)
        {
            this.Root = newNode;
        }

        /// <summary>
        /// Adds a new node to the binary search tree with the given value, maintaining the BST structure of the tree.
        /// </summary>
        /// <param name="value">Value of the node to be added to the binary search tree.</param>
        public void Add(int value)
        {
            bool nodeAdded = false;
            Node<int> addedNode = new Node<int>(value);
            //If the tree is empty, insert at the root
            if (this.Root == null)
            {
                this.Root = addedNode;
            }
            else {
                Node<int> checkedNode = this.Root;
                //if we somehow get past a leaf node, stop trying to add the value; in theory this should never happen with a good implementation
                while (!nodeAdded && checkedNode != null)
                {
                    if (checkedNode.Value > value)
                    {
                        if (checkedNode.LeftChild == null)
                        {
                            checkedNode.LeftChild = addedNode;
                            nodeAdded = true;
                        }
                        else
                        {
                            checkedNode = checkedNode.LeftChild;
                        }
                    }
                    else
                    {
                        if (checkedNode.RightChild == null)
                        {
                            checkedNode.RightChild = addedNode;
                            nodeAdded = true;
                        }
                        else
                        {
                            checkedNode = checkedNode.RightChild;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Traverses through the BST looking for a given value. If the value exists in the tree, return true; otherwise return false.
        /// </summary>
        /// <param name="value">The value to search for in the tree.</param>
        /// <returns>If the tree contains the value, returns true; else returns false</returns>
        public bool Contains(int value)
        {
            bool treeContains = false;
            Node<int> checkNode = this.Root;
            while(checkNode != null && !treeContains)
            {
                if (checkNode.Value == value)
                {
                    treeContains = true;
                }
                else if(checkNode.Value > value)
                {
                    checkNode = checkNode.LeftChild;
                }
                else
                {
                    checkNode = checkNode.RightChild;
                }
            }
            return treeContains;
        }
    }
}
