// ArrayStack.cs

namespace Ukonline.Datastructures
{
	/// Array-based implementation of a stack.
	public class ArrayStack<E> : Stack<E>
	{
		private readonly E[] data;      // Elements of this stack
		private int top;                // Index of the top of this stack
		private readonly int capacity;  // Capacity of this stack

		/// <summary>
		/// Creates a new empty stack.
		/// </summary>
		/// <param name="capacity">The capacity of the stack.</param>
		public ArrayStack (int capacity)
		{
			data = new E[capacity];
			top = -1;
			this.capacity = capacity;
		}

		public int Size()
		{
			return top + 1;
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

			return data[top];
		}

		public void Push (E element)
		{
			if (Size() == capacity)
			{
				throw new FullStackException();
			}

			data[++top] = element;
		}

		public E Pop()
		{
			if (IsEmpty())
			{
				throw new EmptyStackException();
			}

			E element = data[top];
			data[top--] = default (E);
			return element;
		}
	}
}
