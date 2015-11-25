// Stack.java

package be.ukonline.datastructures;

/**
 * Interface for the Stack ADT.
 * 
 * @author Sébastien Combéfis
 * @version November 25, 2015
 */
public interface Stack<E>
{
	/**
	 * Gets the size of the stack.
	 */
	public int size();
	
	/**
	 * Tests whether the stack is empty.
	 */
	public boolean isEmpty();
	
	/**
	 * Gets the element at the top of the stack.
	 */
	public E top() throws EmptyStackException;

	/**
	 * Adds an element at the top of the stack.
	 */
	public void push (E elem);
	
	/**
	 * Removes and returns the element at the top of the stack.
	 */
	public E pop() throws EmptyStackException;
}