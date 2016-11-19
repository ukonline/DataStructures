// LinkedDeque.cs

namespace Ukonline.Datastructures
{
	/// Linked-list implementation of a deque.
	public class LinkedDeque<E> : Deque<E>
	{
		private DequeItem first, last;  // Nodes with first and last elements of this deque
		private int size;               // Size of this deque

		/// <summary>
		/// Creates a new empty deque.
		/// </summary>
		public LinkedDeque()
		{
			first = null;
			last = null;
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

		public E First()
		{
			if (IsEmpty())
			{
				throw new EmptyDequeException();
			}

			return first.element;
		}

		public E Last()
		{
			if (IsEmpty())
			{
				throw new EmptyDequeException();
			}

			return last.element;
		}

		public void InsertFirst (E element)
		{
			DequeItem item = new DequeItem (element, null, first);
			if (first != null)
			{
				first.previous = item;
			}
			first = item;
			size++;

			if (size == 1)
			{
				last = first;
			}
		}

		public void InsertLast (E element)
		{
			DequeItem item = new DequeItem (element, last, null);
			if (last != null)
			{
				last.next = item;
			}
			last = item;
			size++;

			if (size == 1)
			{
				first = last;
			}
		}

		public E RemoveFirst()
		{
			if (IsEmpty())
			{
				throw new EmptyDequeException();
			}

			E element = first.element;
			first = first.next;
			if (first != null)
			{
				first.previous = null;
			}
			size--;
			if (IsEmpty())
			{
				last = null;
			}

			return element;
		}

		public E RemoveLast()
		{
			if (IsEmpty())
			{
				throw new EmptyDequeException();
			}

			E element = last.element;
			last = last.previous;
			if (last != null)
			{
				last.next = null;
			}
			size--;
			if (IsEmpty())
			{
				first = null;
			}

			return element;
		}

		/// Item of the deque.
		private class DequeItem
		{
			public readonly E element;
			public DequeItem previous, next;

			public DequeItem (E element, DequeItem previous, DequeItem next)
			{
				this.element = element;
				this.previous = previous;
				this.next = next;
			}
		}
	}
}
