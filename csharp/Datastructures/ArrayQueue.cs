// ArrayQueue.cs

using System;

namespace Ukonline.Datastructures
{
	/// Array-based implementation of a queue.
	public class ArrayQueue<E> : Queue<E>
	{
		private readonly E[] data;      // Elements of this queue
		private int front, rear;        // Index of front and rear of this queue
		private readonly int capacity;  // Capacity of this queue
		private int size;               // Size of this stack

		/// <summary>
		/// Creates a new empty queue.
		/// </summary>
		/// <param name="capacity">The capacity of the queue.</param>
		public ArrayQueue (int capacity)
		{
			data = new E[capacity];
			front = 0;
			rear = 0;
			size = 0;
			this.capacity = capacity;
		}

		public int Size()
		{
			return size;
		}

		public bool IsEmpty()
		{
			return front == rear;
		}

		public E Front()
		{
			if (IsEmpty())
			{
				throw new EmptyQueueException();
			}
			return data[front];
		}

		public void Enqueue (E element)
		{
			if (Size() == capacity)
			{
				throw new FullQueueException();
			}
			data[rear] = element;
			rear = (rear + 1) % capacity;
			size++;
		}

		public E Dequeue()
		{
			if (IsEmpty())
			{
				throw new EmptyQueueException();
			}
			E element = data[front];
			data[front] = default(E);
			front = (front + 1) % capacity;
			size--;
			return element;
		}
	}
}