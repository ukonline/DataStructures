// LinkedQueue.cs

namespace Ukonline.Datastructures
{
	/// Linked-list implementation of a queue.
	public class LinkedQueue<E> : Queue<E>
	{
		private QueueItem front, rear;  // Nodes with front and rear elements of this queue
		private int size;               // Size of this queue

		/// <summary>
		/// Creates a new empty queue.
		/// </summary>
		public LinkedQueue()
		{
			front = null;
			rear = null;
			size = 0;
		}

		public int Size()
		{
			return size;
		}

		public bool IsEmpty()
		{
			return Size() == 0;
		}

		public E Front()
		{
			if (IsEmpty())
			{
				throw new EmptyQueueException();
			}

			return front.element;
		}

		public void Enqueue (E element)
		{
			QueueItem item = new QueueItem (element, null);
			if (IsEmpty())
			{
				front = rear = item;
			}
			else
			{
				rear.next = item;
				rear = item;
			}
			size++;
		}

		public E Dequeue()
		{
			if (IsEmpty())
			{
				throw new EmptyQueueException();
			}

			E element = front.element;
			front = front.next;
			size--;
			if (IsEmpty())
			{
				rear = null;
			}
			return element;
		}

		/// Item of the queue.
		private class QueueItem
		{
			public readonly E element;
			public QueueItem next;

			public QueueItem (E element, QueueItem next)
			{
				this.element = element;
				this.next = next;
			}
		}
	}
}
