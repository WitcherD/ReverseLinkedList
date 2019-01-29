namespace ReverseLinkedList
{
    /// <summary>
    /// A node in <see cref="LinkedList{T}"/>
    /// </summary>
    public class LinkedListNode<T>
    {
        /// <summary>
        /// Value
        /// </summary>
        public T Value { get; set; }

        /// <summary>
        /// Link to the next element
        /// </summary>
        public LinkedListNode<T> Next { get; set; }

        /// <inheritdoc />
        public LinkedListNode(T value)
        {
            Value = value;
            Next = null;
        }
    }
}