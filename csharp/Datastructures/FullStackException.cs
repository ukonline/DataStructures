// FullStackException.cs

using System;

namespace Ukonline.Datastructures
{
	/// Exception to be thrown for operation forbidden on a full stack.
	public class FullStackException : Exception
	{
		/// <summary>
		/// Creates a new instance of this class.
		/// </summary>
		public FullStackException() : base ("Full stack."){}
	}
}
