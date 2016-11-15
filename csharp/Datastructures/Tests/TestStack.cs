// TestStack.cs

using NUnit.Framework;
using System;

namespace Ukonline.Datastructures.Tests
{
	/// Generic tests for stack implementations.
	public abstract class TestStack
	{
		protected Stack<int> stack;

		[SetUp]
		public abstract void Init();

		[Test]
		public void TestSize()
		{
			Assert.AreEqual (0, stack.Size());

			stack.Push (42);
			Assert.AreEqual (1, stack.Size());

			stack.Push (7);
			stack.Push (3);
			Assert.AreEqual (3, stack.Size());

			stack.Top();
			Assert.AreEqual (3, stack.Size());

			stack.Pop();
			Assert.AreEqual (2, stack.Size());

			stack.Pop();
			stack.Pop();
			Assert.AreEqual (0, stack.Size());
		}

		[Test]
		public void TestIsEmpty()
		{
			Assert.True (stack.IsEmpty());

			stack.Push (42);
			Assert.False (stack.IsEmpty());

			stack.Push (7);
			stack.Push (3);
			Assert.False (stack.IsEmpty());

			stack.Top();
			Assert.False (stack.IsEmpty());

			stack.Pop();
			Assert.False (stack.IsEmpty());

			stack.Pop();
			stack.Pop();
			Assert.True (stack.IsEmpty());
		}

		[Test]
		public void TestTop()
		{
			Assert.Throws<EmptyStackException> (delegate { stack.Top(); });

			stack.Push (42);
			Assert.AreEqual (42, stack.Top());

			stack.Push (7);
			stack.Push (3);
			Assert.AreEqual (3, stack.Top());

			stack.Pop();
			Assert.AreEqual (7, stack.Top());
		}

		[Test]
		public void TestPush()
		{
			stack.Push (42);
			Assert.AreEqual (42, stack.Top());

			stack.Push (7);
			stack.Push (3);
			Assert.AreEqual (3, stack.Top());
		}

		[Test]
		public void TestPop()
		{
			Assert.Throws<EmptyStackException> (delegate { stack.Pop(); });

			stack.Push (42);
			Assert.AreEqual (42, stack.Pop());
			Assert.Throws<EmptyStackException> (delegate { stack.Top(); });

			stack.Push (7);
			stack.Push (3);
			Assert.AreEqual (3, stack.Pop());
			Assert.AreEqual (7, stack.Top());
		}
	}

	[TestFixture]
	/// Tests for array-based stack implementation.
	public class TestArrayStack : TestStack
	{
		public override void Init()
		{
			stack = new ArrayStack<int> (5);
		}

		[Test]
		public void TestFullStack()
		{
			stack.Push (1);
			stack.Push (2);
			stack.Push (3);
			stack.Push (4);
			stack.Push (5);

			Assert.Throws<FullStackException> (delegate { stack.Push (6); });
		}
	}

	[TestFixture]
	/// Tests for linked-list stack implementation.
	public class TestLinkedStack : TestStack
	{
		public override void Init()
		{
			stack = new LinkedStack<int>();
		}
	}
}
