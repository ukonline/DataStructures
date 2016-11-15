// FullQueueException.cs

using System;

namespace Ukonline.Datastructures
{
	/// Exception to be thrown for operation forbidden on a full queue.
	public class FullQueueException : Exception
	{
		/// <summary>
		/// Creates a new instance of this class.
		/// </summary>
		public FullQueueException() : base ("Full queue."){}
	}
}
