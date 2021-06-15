<Query Kind="Program" />

void Main()
{
	Stack<string> first = new();
	first.x = "Ok";
	first.Get();
	
	Stack<int> second = new();
	second.x = 11;
	second.Get();
	
	SpecialStack<int> third = new();
	third.x = 123;
	((Stack<int>)third).x = 124; //casting to set x from base Stack<int>
	third.Get();
	third.GetSpecial();
	
	FloatStack fStack = new();
	fStack.x.Dump();
	fStack.x = 1.55F;
	fStack.x.Dump();
	fStack.GetFloat();
	fStack.Get();
	((Stack<float>)fStack).x = 100.22F;
	fStack.Get();
}

public class Stack<T>
{
	public T x;
	public T Get() => x.Dump();
}

class SpecialStack<T> : Stack<T>
{
	public new T x;
	public T GetSpecial() => x.Dump();
}

class IntStack : Stack<int> {}

class FloatStack : Stack<float>
{
	public new float x = 1.22F;
	public float GetFloat() => x.Dump();
}
