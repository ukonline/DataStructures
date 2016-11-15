using System;

namespace Ukonline.Datastructures
{
	public class EmptyQueueException : Exception
	{
		public EmptyQueueException() : base ("Empty queue")
		{
		}
	}
}