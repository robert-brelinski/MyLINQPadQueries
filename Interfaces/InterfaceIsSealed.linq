<Query Kind="Program" />

void Main()
{
	A a = new();
	a.Undo();
	
	B b = new();
	b.Undo();
	
	A a1 = b;
	a1.Undo();
}

interface IUndo
{
	void Undo(); //it is sealed
}

class A : IUndo
{
	public virtual void Undo() => "Undo".Dump();
}

class B : A
{
	public override void Undo() => "Undo from B".Dump();	
}