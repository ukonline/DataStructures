// EmptyQueueException.cs

using System;

namespace Ukonline.Datastructures
{
	/// Exception to be thrown for operation forbidden on an empty queue.
	public class EmptyQueueException : Exception
	{
		/// <summary>
		/// Creates a new instance of this class.
		/// </summary>
		public EmptyQueueException() : base ("Empty queue."){}
	}
}
