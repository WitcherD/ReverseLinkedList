namespace ReverseLinkedList
{
    /// <summary>
    /// Simple one-way LinkedList
    /// </summary>
    public class LinkedList<T>
    {
        /// <summary>
        /// The first element in LinkedList
        /// </summary>
        public LinkedListNode<T> First { get; set; }
        
        /// <summary>
        /// Add new element to the end
        /// </summary>
        public void Add(T value)
        {
            var newElement = new LinkedListNode<T>(value);
            if (First == null)
            {
                First = newElement;
            }
            else
            {
                newElement.Next = First;
                First = newElement;
            }
        }
    }
}