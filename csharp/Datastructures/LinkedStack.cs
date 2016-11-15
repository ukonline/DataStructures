// LinkedStack.cs

namespace Ukonline.Datastructures
{
	/// Linked-list implementation of a stack.
	public class LinkedStack<E> : Stack<E>
	{
		private StackItem top;          // Node with top element of this stack
		private int size;               // Size of this stack

		/// <summary>
		/// Creates a new empty stack.
		/// </summary>
		public LinkedStack()
		{
			top = null;
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

		public E Top()
		{
			if (IsEmpty())
			{
				throw new EmptyStackException();
			}

			return top.element;
		}

		public void Push (E element)
		{
			top = new StackItem (element, top);
			size++;
		}

		public E Pop()
		{
			if (IsEmpty())
			{
				throw new EmptyStackException();
			}

			E element = top.element;
			top = top.next;
			size--;
			return element;
		}

		/// Item of the stack.
		private class StackItem
		{
			public readonly E element;
			public readonly StackItem next;

			public StackItem (E element, StackItem next)
			{
				this.element = element;
				this.next = next;
			}
		}
	}
}
