using System.Collections.Generic;

namespace DesignPatterns.Iterator
{
    public class Node<T>
    {
        public T Value { get; }
        public Node<T> Left { get; set; }
        public Node<T> Right { get; set; }
        public Node<T> Parent { get; set; }

        public Node(T value)
        {
            Value = value;
        }

        public Node(T value, Node<T> left, Node<T> right)
            : this(value)
        {
            Left = left;
            Right = right;

            if (left != null)
                left.Parent = this;
            if (right != null)
                right.Parent = this;
        }

        public IEnumerable<T> PreOrder
        {
            get
            {
                yield return Value;

                if (Left != null)
                {
                    foreach (T value in Left?.PreOrder)
                        yield return value;
                }
                if (Right != null)
                {
                    foreach (T value in Right?.PreOrder)
                        yield return value;
                }
            }
        }
    }
}
