using System;
using System.Collections;
using System.Collections.Generic;
using System.Management.Instrumentation;
using System.Runtime.InteropServices;

namespace Binary_Trees
{
    public class BinaryTree<T> : IEnumerable<T>
        where T:IComparable<T>
    {
        private BinaryTreeNode<T> head;
        private int count;

        #region Add

        public void Add(T value)
        {
            //Case 1: The tree is empty - allocate the head
            if (head == null)
            {
                head = new BinaryTreeNode<T>(value);
            }
            //Case 2: the tree is not emprty so find the right location to insert
            else
            {
                AddTo(head,value);
            }

            count++;
        }
        //recursive add algorithm
        private void AddTo(BinaryTreeNode<T> node, T value)
        {
            //Case 1: Value is less than the current node value
            if (value.CompareTo(node.Value) < 0)
            {
                //if there is no left child make this the new left
                if (node.Left == null)
                {
                    node.Left = new BinaryTreeNode<T>(value);
                }
                else
                {
                    //else add it to the left node
                    AddTo(node.Left, value);
                }
            }
            //Case 2: Value is equal to or grater than the current value
            else
            {
                //if there is no right, add it to the right
                if (node.Right == null)
                {
                    node.Right = new BinaryTreeNode<T>(value);
                }
                else
                {
                    //else add it to the right node
                    AddTo(node.Right, value);
                }
            }
        }
        #endregion

        /// <summary>
        /// Determines if the specified value exists in the binary tree
        /// </summary>
        /// <param name="value">The value to search for</param>
        /// <returns>True if the tree contains the value, false otherwise</returns>
        public bool Contains(T value)
        {
            //defeer to the node search helper function
            BinaryTreeNode<T> parent;
            return FindWithParent(value, out parent) != null;
        }

        /// <summary>
        /// Finds and returns the first node containing the specified value. If the value 
        /// is not found, returns null. Also returns the parent of the node (null)
        /// which is used in Remove
        /// </summary>
        ///<param name="value">The value to search for</param>
        ///<param name="parent">The parent of the found node</param>
        /// <returns></returns>
        private BinaryTreeNode<T> FindWithParent(T value, out BinaryTreeNode<T> parent)
        {
            //Now, try to find data in the tree
            BinaryTreeNode<T> current = head;
            parent = null;

            //while we dont have a match
            while (current != null)
            {
                int result = current.CompareTo(value);

                if (result > 0)
                {
                    //if the value is less than current, go left
                    parent = current;
                    current = current.Left;
                }
                else if (result < 0)
                {
                    //if the value is more than current, go right
                    parent = current;
                    current = current.Right;
                }
                else
                {
                 //we have a match!
                    break;
                }    
            }
            return current;
        }

        #region Remove

        public bool Remove(T value)
        {
            BinaryTreeNode<T> current, parent;

            current = FindWithParent(value, out parent);

            if (current == null)
            {
                return false;
            }

            count--;

            //Case 1: If current has no right child, then currents left replaces current
            if (current.Right == null)
            {
                if (parent == null)
                {
                    head = current.Left;
                }

                else
                {
                    int result = parent.CompareTo(current.Value);
                    if (result > 0)
                    {
                        // if parent value is greater than current value
                        // make the current left child a left child of parent
                        parent.Left = current.Left;
                    }
                    else if (result < 0)
                    {
                        //if parent value is less than current value
                        //make the current left child a right child of parent
                        parent.Right = current.Left;
                    }
                }
            }
            //case 2: if currents right child has no left child, then currents right child 
            // replaces current
            else if (current.Right.Left == null)
            {
                current.Right.Left = current.Left;
                if (parent == null)
                {
                    head = current.Right;
                }
                else
                {
                    int result = parent.CompareTo(current.Value);
                    if (result > 0)
                    {
                        // if parent value is greater than current value
                        // make the current right child a left child of parent
                        parent.Left = current.Right;
                    }
                    else if (result < 0)
                    {
                        //if parent value is less than current calue
                        //make the current right child a right child of parent
                        parent.Right = current.Right;
                    }
                }
            }
            //case 3: if currents right child has a left child replace current with currents
            //right childs left-most child
            else
            {
                //find the rights left most child
                BinaryTreeNode<T> leftmost = current.Right.Left;
                BinaryTreeNode<T> leftmostParent = current.Right;

                while (leftmost.Left != null)
                {
                    leftmostParent = leftmost;
                    leftmost = leftmost.Left;
                }

                //the parents left subtree becomes the leftmost right subtree
                leftmostParent.Left = leftmost.Right;

                //assign leftmost left and right to current left and right children
                leftmost.Left = current.Left;
                leftmost.Right = current.Right;

                if (parent == null)
                {
                    head = leftmost;
                }
                else
                {
                    int result = parent.CompareTo(current.Value);
                    if (result > 0)
                    {
                        // if parent value is greater than current value
                        // make the parents left child
                        parent.Left = leftmost;
                    }
                    else if (result < 0)
                    {
                        //if parent value is less than current calue
                        //make leftmost the parents right child
                        parent.Right = leftmost;
                    }
                }
            }
            return true;
        }

        #endregion


        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}