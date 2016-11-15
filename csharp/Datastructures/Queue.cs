// Queue.cs

using System;

namespace Ukonline.Datastructures
{
	/// Interface for the Queue ADT
	public interface Queue<E>
	{
		/// <summary>
		/// Gets the size of the queue
		/// </summary>
		/// <returns>The number of elements contained in this queue.</returns>
		int Size();

		/// <summary>
		/// Tests whether the queue is empty.
		/// </summary>
		/// <returns><c>true</c> if this queue is empty; otherwise, <c>false</c>.</returns>
		bool IsEmpty();

		/// <summary>
		/// Gets the element at the front of the queue.
		/// </summary>
		/// <returns>The element at the front of the queue if this queue is not empty.</returns>
		/// <exception cref="Ukonline.EmptyQueueException">Thrown when this queue is empty.</exception>
		E Front();

		/// <summary>
		/// Adds an element at the rear of the queue.
		/// </summary>
		/// <param name="element">Element to be added to this queue.</param>
		void Enqueue (E element);

		/// <summary>
		/// Removes the element at the front of the queue.
		/// </summary>
		/// <returns>The element that was at the front of this queue if this queue is not empty.</returns>
		/// <exception cref="Ukonline.EmptyQueueException">Thrown when this queue is empty.</exception>
		E Dequeue();
	}
}
