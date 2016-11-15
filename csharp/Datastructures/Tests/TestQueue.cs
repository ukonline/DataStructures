// TestQueue.cs

using NUnit.Framework;
using System;

namespace Ukonline.Datastructures.Tests
{
	/// Generic tests for queue implementations.
	public abstract class TestQueue
	{
		protected Queue<int> queue;

		[SetUp]
		public abstract void Init();

		[Test]
		public void TestSize()
		{
			Assert.AreEqual (0, queue.Size());

			queue.Enqueue (42);
			Assert.AreEqual (1, queue.Size());

			queue.Enqueue (7);
			queue.Enqueue (3);
			Assert.AreEqual (3, queue.Size());

			queue.Front();
			Assert.AreEqual (3, queue.Size());

			queue.Dequeue();
			Assert.AreEqual (2, queue.Size());

			queue.Dequeue();
			queue.Dequeue();
			Assert.AreEqual (0, queue.Size());
		}

		[Test]
		public void TestIsEmpty()
		{
			Assert.True (queue.IsEmpty());

			queue.Enqueue (42);
			Assert.False (queue.IsEmpty());

			queue.Enqueue (7);
			queue.Enqueue (3);
			Assert.False (queue.IsEmpty());

			queue.Front();
			Assert.False (queue.IsEmpty());

			queue.Dequeue();
			Assert.False (queue.IsEmpty());

			queue.Dequeue();
			queue.Dequeue();
			Assert.True (queue.IsEmpty());
		}

		[Test]
		public void TestFront()
		{
			Assert.Throws<EmptyQueueException> (delegate { queue.Front(); });

			queue.Enqueue (42);
			Assert.AreEqual (42, queue.Front());

			queue.Enqueue (7);
			queue.Enqueue (3);
			Assert.AreEqual (42, queue.Front());

			queue.Dequeue();
			Assert.AreEqual (7, queue.Front());

			queue.Dequeue();
			Assert.AreEqual (3, queue.Front());
		}

		[Test]
		public void TestEnqueue()
		{
			queue.Enqueue (42);
			Assert.AreEqual (42, queue.Front());

			queue.Enqueue (7);
			queue.Enqueue (3);
			Assert.AreEqual (42, queue.Front());
		}

		[Test]
		public void TestDequeue()
		{
			Assert.Throws<EmptyQueueException> (delegate { queue.Dequeue(); });

			queue.Enqueue (42);
			Assert.AreEqual (42, queue.Dequeue());
			Assert.Throws<EmptyQueueException> (delegate { queue.Front(); });

			queue.Enqueue (7);
			queue.Enqueue (3);
			Assert.AreEqual (7, queue.Dequeue());
			Assert.AreEqual (3, queue.Front());
		}
	}

	[TestFixture]
	/// Tests for array-based queue implementation.
	public class TestArrayQueue : TestQueue
	{
		public override void Init()
		{
			queue = new ArrayQueue<int> (5);
		}

		[Test]
		public void TestFullQueue()
		{
			queue.Enqueue (1);
			queue.Enqueue (2);
			queue.Enqueue (3);
			queue.Enqueue (4);
			queue.Enqueue (5);

			Assert.Throws<FullQueueException> (delegate { queue.Enqueue (6); });
		}
	}

	[TestFixture]
	/// Tests for linked-list queue implementation.
	public class TestLinkedQueue : TestQueue
	{
		public override void Init()
		{
			queue = new LinkedQueue<int>();
		}
	}
}
