// Stack.cs

namespace Ukonline.Datastructures
{
	/// Interface for the Stack ADT.
	public interface Stack<E>
	{
		/// <summary>
		/// Gets the size of the stack.
		/// </summary>
		/// <returns>The number of elements contained in this stack.</returns>
		int Size();

		/// <summary>
		/// Tests whether the stack is empty.
		/// </summary>
		/// <returns><c>true</c> if this stack is empty, and <c>false</c> otherwise.</returns>
		bool IsEmpty();

		/// <summary>
		/// Gets the element at the top of the stack.
		/// </summary>
		/// <returns>The element at the top of this stack if it is not empty.</returns>
		/// <exception cref="Ukonline.EmptyStackException">Thrown when this stack is empty.</exception>
		E Top();

		/// <summary>
		/// Adds an element at the top of the stack.
		/// </summary>
		/// <param name="element">The element to be added.</param>
		void Push (E element);

		/// <summary>
		/// Removes the element at the top of the stack.
		/// </summary>
		/// <returns>The element that was at the top of this stack if it is not empty.</returns>
		/// <exception cref="Ukonline.EmptyStackException">Thrown when the stack is empty.</exception>
		E Pop();
	}
}
