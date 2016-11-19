// Deque.cs

namespace Ukonline.Datastructures
{
	/// Interface for the Deque ADT
	public interface Deque<E>
	{
		/// <summary>
		/// Gets the size of the deque.
		/// </summary>
		/// <returns>The number of elements contained in this deque.</returns>
		int Size();

		/// <summary>
		/// Tests whether the deque is empty.
		/// </summary>
		/// <returns><c>true</c> if this deque is empty; otherwise, <c>false</c>.</returns>
		bool IsEmpty();

		/// <summary>
		/// Gets the element at the front of the deque.
		/// </summary>
		/// <returns>The element at the front of the deque if this deque is not empty.</returns>
		/// <exception cref="Ukonline.EmptyDequeException">Thrown when this deque is empty.</exception>
		E First();

		/// <summary>
		/// Gets the element at the end of the deque.
		/// </summary>
		/// <returns>The element at the end of the deque if this deque is not empty.</returns>
		/// <exception cref="Ukonline.EmptyDequeException">Thrown when this deque is empty.</exception>
		E Last();

		/// <summary>
		/// Adds an element at the front of the deque.
		/// </summary>
		/// <param name="element">Element to be added to this deque.</param>
		void InsertFirst (E element);

		/// <summary>
		/// Adds an element at the end of the deque.
		/// </summary>
		/// <param name="element">Element to be added to this deque.</param>
		void InsertLast (E element);

		/// <summary>
		/// Removes the element at the front of the deque.
		/// </summary>
		/// <returns>The element that was at the front of this deque if this deque is not empty.</returns>
		/// <exception cref="Ukonline.EmptyDequeException">Thrown when this deque is empty.</exception>
		E RemoveFirst();

		/// <summary>
		/// Removes the element at the end of the deque.
		/// </summary>
		/// <returns>The element that was at the end of this deque if this deque is not empty.</returns>
		/// <exception cref="Ukonline.EmptyDequeException">Thrown when this deque is empty.</exception>
		E RemoveLast();
	}
}
