<Query Kind="Program" />

void Main()
{
	A a = new();
	a.Undo();
	
	B b = new();
	b.Undo();
	
	A a1 = b;
	a1.Undo();
	
	C c = new();
	((IUndoable)c).Undo();
	((A)c).Undo();
	c.Undo();
}

interface IUndoable
{
	string Undo();
}

public class A : IUndoable
{
	public string Undo() => "Undo from A".Dump();
}

public class B : A
{
	public new string Undo() => "Undo from B".Dump();
}

public class C : A, IUndoable
{
	public string Undo() => "Undo from C - reimplement".Dump();
}