// TestDeque.cs

using NUnit.Framework;

namespace Ukonline.Datastructures.Tests
{
	/// Generic tests for deque implementations.
	public abstract class TestDeque
	{
		protected Deque<int> deque;

		[SetUp]
		public abstract void Init();

		[Test]
		public void TestSize()
		{
			Assert.AreEqual (0, deque.Size());

			deque.InsertFirst (42);
			Assert.AreEqual (1, deque.Size());

			deque.InsertFirst (7);
			deque.InsertLast (3);
			Assert.AreEqual (3, deque.Size());

			deque.First();
			deque.Last();
			Assert.AreEqual (3, deque.Size());

			deque.RemoveFirst();
			deque.RemoveLast();
			Assert.AreEqual (1, deque.Size());

			deque.RemoveFirst();
			Assert.AreEqual (0, deque.Size());
		}

		[Test]
		public void TestIsEmpty()
		{
			Assert.True (deque.IsEmpty());

			deque.InsertFirst (42);
			Assert.False (deque.IsEmpty());

			deque.InsertFirst (7);
			deque.InsertLast (3);
			Assert.False (deque.IsEmpty());

			deque.First();
			deque.Last();
			Assert.False (deque.IsEmpty());

			deque.RemoveFirst();
			deque.RemoveLast();
			Assert.False (deque.IsEmpty());

			deque.RemoveFirst();
			Assert.True (deque.IsEmpty());
		}

		[Test]
		public void TestFirst()
		{
			Assert.Throws<EmptyDequeException> (delegate { deque.First(); });

			deque.InsertFirst (42);
			Assert.AreEqual (42, deque.First());

			deque.InsertFirst (7);
			deque.InsertFirst (3);
			Assert.AreEqual (3, deque.First());

			deque.InsertLast (9);
			deque.InsertLast (12);
			Assert.AreEqual (3, deque.First());

			deque.RemoveFirst();
			Assert.AreEqual (7, deque.First());

			deque.RemoveLast();
			Assert.AreEqual (7, deque.First());

			deque.RemoveFirst();
			Assert.AreEqual (42, deque.First());
		}

		[Test]
		public void TestLast()
		{
			Assert.Throws<EmptyDequeException> (delegate { deque.Last(); });

			deque.InsertFirst (42);
			Assert.AreEqual (42, deque.Last());

			deque.InsertFirst (7);
			deque.InsertFirst (3);
			Assert.AreEqual (42, deque.Last());

			deque.InsertLast (9);
			deque.InsertLast (12);
			Assert.AreEqual (12, deque.Last());

			deque.RemoveFirst();
			Assert.AreEqual (12, deque.Last());

			deque.RemoveLast();
			Assert.AreEqual (9, deque.Last());

			deque.RemoveLast();
			Assert.AreEqual (42, deque.Last());
		}

		[Test]
		public void TestRemoveFirst()
		{
			Assert.Throws<EmptyDequeException> (delegate { deque.RemoveFirst(); });

			deque.InsertFirst (42);
			Assert.AreEqual (42, deque.RemoveFirst());
			Assert.Throws<EmptyDequeException> (delegate { deque.First(); });

			deque.InsertFirst (7);
			deque.InsertLast (3);
			Assert.AreEqual (7, deque.RemoveFirst());
			Assert.AreEqual (3, deque.First());
		}

		[Test]
		public void TestRemoveLast()
		{
			Assert.Throws<EmptyDequeException> (delegate { deque.RemoveLast(); });

			deque.InsertLast (42);
			Assert.AreEqual (42, deque.RemoveLast());
			Assert.Throws<EmptyDequeException> (delegate { deque.Last(); });

			deque.InsertLast (7);
			deque.InsertFirst (3);
			Assert.AreEqual (7, deque.RemoveLast());
			Assert.AreEqual (3, deque.Last());
		}
	}

	[TestFixture]
	/// Tests for linked-list deque implementation.
	public class TestLinkedDeque : TestDeque
	{
		public override void Init()
		{
			deque = new LinkedDeque<int>();
		}
	}
}
