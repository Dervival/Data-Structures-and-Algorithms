using System;
using System.Collections.Generic;
using System.Text;

namespace Tree.Classes
{
    public class BinarySearchTree : BinaryTree<int>
    {
        public BinarySearchTree()
        {

        }

        public BinarySearchTree(int value)
        {
            Node<int> newNode = new Node<int>(value);
            this.Root = newNode;
        }

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
            if (this.Root == null)
            {
                this.Root = addedNode;
            }
            else {
                Node<int> checkedNode = this.Root;
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
    }
}
