<Query Kind="Program" />

void Main()
{
	var stack = new Stack<int>();
	stack.Push(11);
	stack.Push(12);
	stack.Pop().Dump();
	stack.Pop().Dump();
	
	IHaveAStack<string> have = new();
	have.my.Push("One");
	have.my.Push("Two");
	have.my.Pop().Dump();
}

public class Stack<T>
{
	int position;
	T[] data = new T[100];
	public void Push(T obj) => data[position++] = obj;
	public T Pop() => data[--position];
}

public class IHaveAStack<T>
{
	public Stack<T> my = new Stack<T>();
}
