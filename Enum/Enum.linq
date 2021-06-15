<Query Kind="Program" />

void Main()
{
	Sides.Top.Dump();
	((int)Sides.Bottom).Dump();
	
	((int)Border.Bottom).Dump();
}

public enum Sides
{
	Top, Right, Bottom, Left
}

public enum Border
{
	Top = 1, Right, Bottom =3
}


