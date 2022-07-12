// C# program to implement Queue using
// two stacks with costly enQueue()
using System;
using System.Collections;

class GFG
{
	
public class Queue
{
	public Stack s1 = new Stack();
	public Stack s2 = new Stack();

	public void enQueue(int x)
	{
		// Move all elements from s1 to s2
		while (s1.Count > 0)
		{
			s2.Push(s1.Pop());//1
			//s1.Pop();
		}

		// Push item into s1
		s1.Push(x); //2

		// Push everything back to s1
		while (s2.Count > 0)
		{
			s1.Push(s2.Pop());
			//s2.Pop();
		}
	}

	// Dequeue an item from the queue
	public int deQueue()
	{
		// if first stack is empty
		if (s1.Count == 0)
		{
			Console.WriteLine("Q is Empty");
			
		}

		// Return top of s1
		int x = (int)s1.Peek();
		s1.Pop();
		return x;
	}
};

// Driver code
public static void Main()
{
	Queue q = new Queue();
	q.enQueue(1);
	q.enQueue(2);
	q.enQueue(3);

	Console.Write(q.deQueue()+" ");
	Console.Write(q.deQueue()+" ");
	Console.Write(q.deQueue());
}
}

// This code is contributed by
// Subhadeep Gupta
