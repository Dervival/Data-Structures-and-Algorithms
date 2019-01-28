using System;
using System.Collections.Generic;
using System.Text;

namespace Tree.Classes
{
    public class BinaryTree<T>
    {
        public Node<T> Root { get; set; }

        /// <summary>
        /// Creates a new empty tree. Not incredibly useful until Root is assigned.
        /// </summary>
        public BinaryTree()
        {

        }

        /// <summary>
        /// Creates a new binary tree with the provided node.
        /// </summary>
        /// <param name="node">Node to set the root of the tree to.</param>
        public BinaryTree(Node<T> node)
        {
            Root = node;
        }

        /// <summary>
        /// Creates a new binary tree with a new node instantiated with the given value.
        /// </summary>
        /// <param name="value">Value of the node of the root of the new tree.</param>
        public BinaryTree(T value)
        {
            Node<T> newNode = new Node<T>(value);
            Root = newNode;
        }

        /// <summary>
        /// Default pre-order depth-first search of a binary tree. If no parameter is given, assume the root of the target the DFS is being called upon is the intended target. 
        /// </summary>
        /// <returns>A list of values of type T, representing the values accessed in the tree during the pre-order search in order of when each node was evaluated.</returns>
        public List<T> PreOrderTraversal()
        {
            if(Root == null)
            {
                return null;
            }
            return PreOrderTraversal(Root);
        }

        /// <summary>
        /// Pre-order depth-first search of a binary tree, starting from the given binary tree node.
        /// </summary>
        /// <param name="root">The node to begin the search from.</param>
        /// <returns>A list of values of type T, representing the values accessed in the tree during the pre-order search in order of when each node was evaluated.</returns>
        public List<T> PreOrderTraversal(Node<T> root)
        {
            List<T> PreOrderList = new List<T>();

            //Pre-order traversal - evaluate the root, then everything to the left of the root, then evaluate everything to the right.
            if (root != null)
            {
                PreOrderList.Add(root.Value);
                if (root.LeftChild != null)
                {
                    List<T> LeftTreeList = PreOrderTraversal(root.LeftChild);
                    foreach (T value in LeftTreeList)
                    {
                        PreOrderList.Add(value);
                    }
                }
                if (root.RightChild != null)
                {
                    List<T> RightTreeList = PreOrderTraversal(root.RightChild);
                    foreach (T value in RightTreeList)
                    {
                        PreOrderList.Add(value);
                    }
                }
            }
            return PreOrderList;
        }

        /// <summary>
        /// Default in-order depth-first search of a binary tree. If no parameter is given, assume the root of the target the DFS is being called upon is the intended target. 
        /// </summary>
        /// <returns>A list of values of type T, representing the values accessed in the tree during the in-order search in order of when each node was evaluated.</returns>
        public List<T> InOrderTraversal()
        {
            if (Root == null)
            {
                return null;
            }
            return InOrderTraversal(Root);
        }

        /// <summary>
        /// In-order depth-first search of a binary tree, starting from the given binary tree node.
        /// </summary>
        /// <param name="root">The node to begin the search from.</param>
        /// <returns>A list of values of type T, representing the values accessed in the tree during the in-order search in order of when each node was evaluated.</returns>
        public List<T> InOrderTraversal(Node<T> root)
        {
            List<T> InOrderList = new List<T>();

            //Pre-order traversal - evaluate the root, then everything to the left of the root, then evaluate everything to the right.
            if (root != null)
            {
                if (root.LeftChild != null)
                {
                    List<T> LeftTreeList = InOrderTraversal(root.LeftChild);
                    foreach (T value in LeftTreeList)
                    {
                        InOrderList.Add(value);
                    }
                }

                InOrderList.Add(root.Value);

                if (root.RightChild != null)
                {
                    List<T> RightTreeList = InOrderTraversal(root.RightChild);
                    foreach (T value in RightTreeList)
                    {
                        InOrderList.Add(value);
                    }
                }
            }
            return InOrderList;
        }


        /// <summary>
        /// Default post-order depth-first search of a binary tree. If no parameter is given, assume the root of the target the DFS is being called upon is the intended target. 
        /// </summary>
        /// <returns>A list of values of type T, representing the values accessed in the tree during the post-order search in order of when each node was evaluated.</returns>
        public List<T> PostOrderTraversal()
        {
            if (Root == null)
            {
                return null;
            }
            return PostOrderTraversal(Root);
        }

        /// <summary>
        /// Post-order depth-first search of a binary tree, starting from the given binary tree node.
        /// </summary>
        /// <param name="root">The node to begin the search from.</param>
        /// <returns>A list of values of type T, representing the values accessed in the tree during the post-order search in order of when each node was evaluated.</returns>
        public List<T> PostOrderTraversal(Node<T> root)
        {
            List<T> PostOrderList = new List<T>();

            //Post-order traversal - evaluate everything to the left of the root, then evaluate everything to the right, then evaluate the node.
            if (root != null)
            {
                if (root.LeftChild != null)
                {
                    List<T> LeftTreeList = PostOrderTraversal(root.LeftChild);
                    foreach (T value in LeftTreeList)
                    {
                        PostOrderList.Add(value);
                    }
                }
                if (root.RightChild != null)
                {
                    List<T> RightTreeList = PostOrderTraversal(root.RightChild);
                    foreach (T value in RightTreeList)
                    {
                        PostOrderList.Add(value);
                    }
                }
                PostOrderList.Add(root.Value);
            }
            return PostOrderList;
        }


    }
}
