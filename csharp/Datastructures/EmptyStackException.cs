// EmptyStackException.cs

using System;

namespace Ukonline.Datastructures
{
	/// Exception to be thrown for operation forbidden on an empty stack.
	public class EmptyStackException : Exception
	{
		/// <summary>
		/// Creates a new instance of this class.
		/// </summary>
		public EmptyStackException() : base ("Empty stack."){}
	}
}
