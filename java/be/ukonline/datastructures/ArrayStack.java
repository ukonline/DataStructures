// ArrayStack.java

package be.ukonline.datastructures;

/**
 * Array-based implementation of a stack.
 * 
 * @author Sébastien Combéfis
 * @version November 25, 2015
 */

public class ArrayStack<E> implements Stack<E>
{
	private final int capacity;
	private final E[] data;
	private int top;
	
	@SuppressWarnings("unchecked")
	public ArrayStack()
	{
		capacity = 100;
		data = (E[]) new Object[capacity];
		top = -1;
	}
	
	public void push (E elem) throws FullStackException
	{
		if (size() == capacity)
		{
			throw new FullStackException();
		}
		data[++top] = elem;
	}
	
	public E pop() throws EmptyStackException
	{
		if (isEmpty())
		{
			throw new EmptyStackException();
		}
		E elem = data[top];
		data[top--] = null;
		return elem;
	}
	
	public int size()
	{
		return top + 1;
	}
	
	public boolean isEmpty()
	{
		return size() == 0;
	}
	
	public E top() throws EmptyStackException
	{
		if (isEmpty())
		{
			throw new EmptyStackException();
		}
		return data[top];
	}
}