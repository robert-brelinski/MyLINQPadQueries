<Query Kind="Program" />

void Main()
{
	Point? p = null;
	Nullable<int> x = null;
	
	p.Dump();
	x.Dump();
}

public struct Point { public int X, Y; }
