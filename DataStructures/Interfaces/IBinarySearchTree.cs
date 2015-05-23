﻿
namespace DataStructures
{
    public interface IBinarySearchTree<T> where T : System.IComparable<T>
    {
        /// Returns the number of elements in the Tree
        int Count();

        // Checks if the tree is empty.
        bool IsEmpty();

        // Returns the height of the tree.
        int Height();

        // Inserts an element to the tree
        void Insert(T item);

        // Remove an element from tree
        void Remove(T item);

        // Removes the min value from tree
        void RemoveMin();

        // Removes the max value from tree
        void RemoveMax();

        // Finds the minimum element.
        T FindMin();

        // Finds the maximum element.
        T FindMax();

        // Find the element in the tree, returns null if not found.
        T Find(T item);

        // Finds all the elements in the tree that match the predicate.
        System.Collections.Generic.List<T> FindAll(System.Predicate<T> searchPredicate);

        // Traverses the tree and applies the action to every node.
        void Traverse(System.Action<T> action);

        // Sort the elements in this tree, using in-order traversal, and returns them.
        System.Collections.Generic.List<T> BSTSort();

        // Clear this tree.
        void Clear();
    }

    /// <summary>
    /// The itemed version of the Binary Search Tree.
    /// </summary>
    /// <typeparam name="K">Type of items.</typeparam>
    /// <typeparam name="V">Type of records per node.</typeparam>
    public interface IBinarySearchTree<K, V> where K : System.IComparable<K>
    {
        int Count();
        bool IsEmpty();
        void Insert(K item, V value);
        void Remove(K item);
        void RemoveMin();
        void RemoveMax();
        K Find(K item);
        K FindMin();
        K FindMax();
        System.Collections.Generic.List<V> FindAll(System.Predicate<K> searchPredicate);
        void Traverse(System.Action<K> action);
        System.Collections.Generic.List<V> BSTSort();
        void Clear();
    }
}
