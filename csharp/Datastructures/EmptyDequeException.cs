// EmptyDequeException.cs

using System;

namespace Ukonline.Datastructures
{
	/// Exception to be thrown for operation forbidden on an empty deque.
	public class EmptyDequeException : Exception
	{
		/// <summary>
		/// Creates a new instance of this class.
		/// </summary>
		public EmptyDequeException() : base ("Empty deque."){}
	}
}
