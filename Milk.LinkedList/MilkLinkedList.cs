using System;
using Milk.LinkedList.Classes;

namespace Milk.LinkedList
{
    public class MilkLinkedList<T>
    {
        public MilkNode HeadNode { get; set; }
        public MilkNode CurrentNode { get; set; }

        /// <summary>
        /// Instantiates a Doubly Linked MilkLinkedList Object
        /// </summary>
        public MilkLinkedList()
        {
            
        }

        /// <summary>
        /// Instantiates a Doubly Linked MilkLinkedList Object with a headnode
        /// </summary>
        /// <param name="headNode">HeadNode</param>
        public MilkLinkedList(MilkNode headNode)
        {
            HeadNode = headNode;
            CurrentNode = HeadNode;
        }

        /// <summary>
        /// Return the data at the specified index
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public T this[int index] => (T) Traverse(index).CurrentNode.Data;

        /// <summary>
        /// Inserts data into the Linked List
        /// </summary>
        /// <typeparam name="T">The Type of the Data To insert</typeparam>
        /// <param name="obj">The Data To Insert</param>
        /// <param name="pos">The Position to Insert the Data at. if left empty will insert to the end of the list</param>
        public void Insert(T obj,int pos = 0)
        {
            if (pos > 0)
            {
                TraversalResult result = Traverse(pos);
                MilkNode nodeToInsert = new MilkNode(result.PreviousNode, obj, result.CurrentNode);
                result.PreviousNode.NextNode = nodeToInsert;
                result.CurrentNode.PreviousNode = nodeToInsert;
            }
            else
            {
                MilkNode nodeToInsert = new MilkNode(CurrentNode, obj, null);
                if (HeadNode == null)
                {
                    HeadNode = nodeToInsert;
                }
                else
                {
                    CurrentNode.NextNode = nodeToInsert;
                }
                CurrentNode = nodeToInsert;
            }
        }

        /// <summary>
        /// Deletes data at the position in the Linked List
        /// </summary>
        /// <param name="pos">the position of the node to remove, if left empty will remove the last Node</param>
        public void Delete(int pos = 0)
        {
            if (pos > 0)
            {
                TraversalResult result = Traverse(pos);
                result.PreviousNode.NextNode = result.NextNode;
                result.NextNode.PreviousNode = result.PreviousNode;
            }
            else
            {
                if (CurrentNode == HeadNode)
                {
                    CurrentNode = null;
                }
                CurrentNode = CurrentNode.PreviousNode;
                CurrentNode.NextNode = null;
            }


        }

        /// <summary>
        /// Prints out a String Interpretation of the data stored in each node
        /// </summary>
        /// <returns></returns>
        public string PrintList()
        {
            string res = "";
            MilkNode currentNode = HeadNode;
            while (currentNode != null)
            {
                res += $"{currentNode.ToString()}\n";
                currentNode = currentNode.NextNode;
            }

            return res;
        }

        /// <summary>
        /// Traverses through the MilkLinkedList to find the MilkNode at a given postion 
        /// </summary>
        /// <param name="pos">The position of </param>
        /// <returns><see cref="TraversalResult"/></returns>
        private TraversalResult Traverse(int pos)
        {
            MilkNode memento = null;
            MilkNode current = HeadNode;
            MilkNode next = null;
            MilkNode temp = null;
            int count = 0;
            while (count != pos)
            {
                temp = current;
                memento = temp;
                current = memento.NextNode;
                if (current == null)
                    throw new IndexOutOfRangeException("Supplied Position is not within the bounds of the linked list");
                next = current.NextNode;
                count++;
            }

            return new TraversalResult(memento, current, next);
        }
    }
}
