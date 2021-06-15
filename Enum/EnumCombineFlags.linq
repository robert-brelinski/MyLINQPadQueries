<Query Kind="Program" />

void Main()
{
	Sides.Bottom.Dump();
	Sides.Bottom.ToString().Dump();
	
	Sides s = Sides.Left | Sides.Right;
	s.ToString().Dump();
}

[Flags]
public enum Sides
{
	Top = 2,
	Right = 4,
	Bottom = 8,
	Left = 16
}

//